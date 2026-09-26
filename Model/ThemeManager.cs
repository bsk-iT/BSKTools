﻿using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _4RTools.Utils
{
    public static class ThemeManager
    {
        // ===== NOVA PALETA DE CORES =====
        public static readonly Color BlackBase = Color.FromArgb(28, 28, 28);
        public static readonly Color DarkGray = Color.FromArgb(28, 28, 28);
        public static readonly Color MediumGray = Color.FromArgb(28, 28, 28);
        public static readonly Color LightGray = Color.FromArgb(28, 28, 28);
        public static readonly Color WhiteBase = Color.FromArgb(244, 244, 246);

        // ===== CORES PARA DIFERENTES USOS =====
        public static readonly Color BackgroundDark = BlackBase;        // Fundo escuro principal
        public static readonly Color BackgroundMedium = DarkGray;       // Fundo médio para controles
        public static readonly Color BorderColor = MediumGray;          // Cor de bordas
        public static readonly Color TextPrimary = WhiteBase;           // Texto principal
        public static readonly Color TextSecondary = LightGray;         // Texto secundário

        // ===== APIs PARA BARRA DE TÍTULO ESCURA =====
        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern void DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref bool attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        private const int DWMWA_CAPTION_COLOR = 35;

        public static bool IsLight { get; private set; }

        /// <summary>
        /// Barra de título conforme o tema atual (escura por padrão)
        /// </summary>
        public static void ApplyTitleBar(Form form)
        {
            try
            {
                if (form.Handle != IntPtr.Zero)
                {
                    bool useImmersiveDarkMode = !IsLight;

                    if (DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useImmersiveDarkMode, sizeof(bool)) != 0)
                    {
                        DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1, ref useImmersiveDarkMode, sizeof(bool));
                    }

                    int captionColor = ColorToInt(IsLight ? LightBackground : DarkGray);
                    DwmSetWindowAttribute(form.Handle, DWMWA_CAPTION_COLOR, ref captionColor, sizeof(int));
                }
            }
            catch { }
        }

        /// <summary>
        /// NOVO: Aplica cor escura ao MdiClient (área de fundo do MDI Container)
        /// </summary>
        public static void ApplyDarkMdiClientBackground(Form mdiContainer)
        {
            try
            {
                foreach (Control control in mdiContainer.Controls)
                {
                    if (control is MdiClient mdiClient)
                    {
                        mdiClient.BackColor = BackgroundDark;  // Usando preto para fundo MDI
                        break; // Só existe um MdiClient por form
                    }
                }
            }
            catch { }
        }

        private static int ColorToInt(Color color)
        {
            return color.R | (color.G << 8) | (color.B << 16);
        }

        // ===== TEMA CLARO =====
        // The dark palette is hard-coded in ~30 Designer files, so the light theme remaps those
        // colors at runtime and remembers each original to restore the dark theme.
        // Grey, not white: the themed TabControl frame is always drawn near-white (249), so a
        // white page would swallow it. Panels (20 in dark) invert to a lighter step.
        private static readonly Color LightBackground = Color.FromArgb(226, 226, 226);
        private static readonly Color LightPanel = Color.FromArgb(236, 236, 236);
        private static readonly Color LightInput = Color.FromArgb(255, 255, 255);
        private static readonly Color LightSeparator = Color.FromArgb(170, 170, 170);
        private static readonly Color LightText = Color.FromArgb(30, 30, 30);

        private sealed class Original { public Color? Back, Fore, Border; }
        private static readonly ConditionalWeakTable<Control, Original> originals = new ConditionalWeakTable<Control, Original>();
        private static readonly ConditionalWeakTable<Control, Original> hooked = new ConditionalWeakTable<Control, Original>();
        private static bool applying;

        public static void SetTheme(bool light, Control root)
        {
            IsLight = light;
            Apply(root);
        }

        private static void Apply(Control root)
        {
            bool previous = applying;
            applying = true;
            try { Walk(root); }
            finally { applying = previous; }
        }

        private static void Walk(Control c)
        {
            if (!hooked.TryGetValue(c, out _))
            {
                hooked.Add(c, null);
                c.BackColorChanged += OnBackColorChanged;
                c.ForeColorChanged += OnForeColorChanged;
                c.ControlAdded += (s, e) => { if (IsLight) Apply(e.Control); };
            }
            Recolor(c);
            foreach (Control child in c.Controls)
                Walk(child);
            if (c is Form form && form.TopLevel)
                ApplyTitleBar(form);
        }

        // Parents are recolored before children, so a child that only inherits its color reads
        // the new light value, matches nothing and stays inheriting.
        private static void Recolor(Control c)
        {
            Original o = originals.GetOrCreateValue(c);
            ButtonBase button = c as ButtonBase;
            if (IsLight)
            {
                Color? back = LightBack(c, c.BackColor);
                if (back.HasValue) { o.Back = c.BackColor; c.BackColor = back.Value; }
                Color? fore = LightFore(c.ForeColor);
                if (fore.HasValue) { o.Fore = c.ForeColor; c.ForeColor = fore.Value; }
                if (button != null)
                {
                    Color? border = LightFore(button.FlatAppearance.BorderColor);
                    if (border.HasValue) { o.Border = button.FlatAppearance.BorderColor; button.FlatAppearance.BorderColor = border.Value; }
                }
                return;
            }
            if (o.Back.HasValue) { c.BackColor = o.Back.Value; o.Back = null; }
            if (o.Fore.HasValue) { c.ForeColor = o.Fore.Value; o.Fore = null; }
            if (o.Border.HasValue && button != null) { button.FlatAppearance.BorderColor = o.Border.Value; o.Border = null; }
        }

        // Code that sets a color while the light theme is on (DebugForm, renderers) gets remapped;
        // a neutral color set by code (red/green status) is kept in both themes.
        private static void OnBackColorChanged(object sender, EventArgs e)
        {
            if (applying || !IsLight) return;
            Control c = (Control)sender;
            Original o = originals.GetOrCreateValue(c);
            Color? back = LightBack(c, c.BackColor);
            o.Back = back.HasValue ? c.BackColor : (Color?)null;
            if (back.HasValue) Set(() => c.BackColor = back.Value);
        }

        private static void OnForeColorChanged(object sender, EventArgs e)
        {
            if (applying || !IsLight) return;
            Control c = (Control)sender;
            Original o = originals.GetOrCreateValue(c);
            Color? fore = LightFore(c.ForeColor);
            o.Fore = fore.HasValue ? c.ForeColor : (Color?)null;
            if (fore.HasValue) Set(() => c.ForeColor = fore.Value);
        }

        private static void Set(System.Action set)
        {
            bool previous = applying;
            applying = true;
            try { set(); }
            finally { applying = previous; }
        }

        private static Color? LightBack(Control c, Color color)
        {
            int argb = color.ToArgb();
            if (argb == Color.FromArgb(28, 28, 28).ToArgb()) return LightBackground;
            if (argb == Color.FromArgb(20, 20, 20).ToArgb()) return LightPanel;
            if (argb == Color.FromArgb(50, 50, 50).ToArgb()) return LightInput;
            if (argb == Color.Silver.ToArgb()) return LightSeparator;
            // Black is a key TextBox in the buff renderers and a separator line in AHKForm.
            if (argb == Color.Black.ToArgb()) return c is TextBoxBase ? LightInput : LightSeparator;
            return null;
        }

        private static Color? LightFore(Color color)
        {
            int argb = color.ToArgb();
            if (argb == Color.White.ToArgb()) return LightText;
            // TextPrimary/WhiteBase (244,244,246): DebugForm's labels.
            if (argb == WhiteBase.ToArgb()) return LightText;
            // GDI ignores alpha, so a Transparent ForeColor (header labels) renders as white.
            if (argb == Color.Transparent.ToArgb()) return LightText;
            // Bright accents are unreadable on white: darker shades of the same hue.
            if (argb == Color.Gold.ToArgb()) return Color.FromArgb(150, 105, 0);
            if (argb == Color.Yellow.ToArgb()) return Color.FromArgb(140, 100, 0);
            if (argb == Color.Lime.ToArgb()) return Color.FromArgb(0, 130, 0);
            if (argb == Color.Cyan.ToArgb()) return Color.FromArgb(0, 110, 150);
            if (argb == Color.FromArgb(148, 155, 164).ToArgb()) return Color.FromArgb(90, 96, 104);
            return null;
        }
    }
}