using System;
using System.ComponentModel;

namespace _4RTools.Utils
{

    [Flags]
    public enum EffectStatusIDs : uint
    {
        
        [Description("Provocar")]
        PROVOKE = 2015,
        MISTY_FROST = 1141,
        OVERHEAT = 373,
        [Description("Vigor")]
        ENDURE = 1,
        PAINKILLER = 577,
        [Description("Rapidez com Lança")]
        SPEARQUICKEN = 68,
        [Description("Transformação em Monstro")]
        MONSTER_TRANSFORM = 621,
        [Description("Prestígio Divino")]
        PRESTIGE = 402,
        [Description("Consagração")]
        INSPIRATION = 407,
        [Description("Aegis Domini")]
        SHIELDSPELL = 1316,
        [Description("Rufar dos Tambores")]
        DRUMBATTLEFIELD = 80,
        [Description("Anel dos Nibelungos")]
        RINGNIBELUNGEN = 81,
        [Description("Milagre Solar, Lunar e Estelar")]
        MIRACLE= 2113,
        [Description("Espírito")]
        SPIRIT = 1401,
        [Description("Calor Solar, Lunar, Estelar")]
        WARM = 165,
        [Description("Proteção Solar")]
        SUN_COMFORT = 169,
        [Description("Proteção Lunar")]
        MOON_COMFORT = 170,
        [Description("Proteção Estelar")]
        STAR_COMFORT = 171,
        [Description("Disparo Selvagem")]
        FEARBREEZE = 352,
        SOULLINK = 149,
        [Description("Concentração")]
        CONCENTRATION = 3,
        [Description("Visão Real")]
        TRUESIGHT = 115,
        [Description("Glória")]
        GLORIA = 21,
        [Description("Magnificat")]
        MAGNIFICAT = 20,
        [Description("Angelus")]
        ANGELUS = 9,
        [Description("Lauda Agnus")]
        LAUDA_AGNUS = 331,
        [Description("Lauda Ramus")]
        LAUDA_RAMUS = 332,
        [Description("Caminho do vento")]
        WINDWALK = 116,
        [Description("Força Violenta")]
        OVERTHRUST = 25,
        [Description("Força Violentíssima")]
        OVERTHRUSTMAX = 188,
        [Description("Manejo Perfeito")]
        WEAPONPERFECT = 24,
        [Description("Amplificar Poder")]
        MAXIMIZE = 26,
        [Description("Grito de Guerra")]
        CRAZY_UPROAR = 30,
        [Description("Impulso no Carrinho")]
        CARTBOOST = 118,
        [Description("Golpe Estilhaçante")]
        MELTDOWN = 117,
        [Description("Adrenalina Pura")]
        ADRENALINE = 23,
        [Description("Adrenalina Concentrada")]
        ADRENALINE2 = 147,
        [Description("Proteção Arcana")]
        ENERGYCOAT = 31,
        [Description("Explosão Protetora")]
        SIGHTBLASTER = 198,
        [Description("Desejo Arcano")]
        AUTOSPELL = 65,
        [Description("Lanças Duplas")]
        DOUBLECASTING = 186,
        [Description("Presciência")]
        MEMORIZE = 127,
        [Description("Preservar")]
        PRESERVE = 181,
        [Description("Instinto de Defesa")]
        SWORDREJECT = 120,
        [Description("Encantar com Veneno Mortal")]
        EDP = 114,
        [Description("Refletir Veneno")]
        POISONREACT = 7,
        [Description("Bloqueio")]
        AUTOGUARD = 58,
        [Description("Escudo Refletor")]
        REFLECTSHIELD = 59,
        [Description("Aura Sagrada")]
        DEFENDER = 62,
        [Description("Submissão")]
        CR_SHRINK = 197,
        [Description("Rapidez com Uma Mão")]
        ONEHANDQUICKEN = 161,
        [Description("Rapidez com Duas Mãos")]
        TWOHANDQUICKEN = 2,
        [Description("Lâmina de Aura")]
        AURABLADE = 103,
        [Description("Dedicação")]
        LKCONCENTRATION = 105,
        [Description("Aparar Golpe")]
        PARRYING = 104,
        [Description("Frenesi")]
        BERSERK = 2108,
        [Description("Instinto de Sobrevivência")]
        AUTOBERSERK = 132,
        [Description("Aura Ninja")]
        AURA_NINJA = 208,
        [Description("Troca de Pele")]
        PEEL_CHANGE = 206,
        [Description("Encantar Lâmina")]
        ENCHANT_BLADE = 316,
        INFINITY_DRINK = 1065,
        OVERLAPEXPUP = 618,
        [Description("Proteção Arcana")]
        PROTECTARMOR = 56,
        [Description("Telecinesia")]
        TELEKINESIS_INTENSE = 717,
        [Description("Amplificação Mística")]
        MYST_AMPLIFY = 113,
        [Description("Aceleração")]
        ACCELERATION = 361,
        [Description("Ataque Gatling")]
        GATLINGFEVER = 204,
        [Description("Assumptio")]
        ASSUMPTIO = 110,
        [Description("Proteção da Vanguarda")]
        FORCEOFVANGUARD = 391,
        [Description("Ilimitar")]
        UNLIMIT = 722,
        [Description("Assovio")]
        WHISTLE = 70,
        [Description("Crepúsculo Sangrento")]
        ASSASSINCROSS = 71,
        [Description("Poema de Bragi")]
        POEMBRAGI = 72,
        [Description("Maçãs de Idun")]
        APPLEIDUN = 73,
        [Description("Sibilo")]
        HUMMING = 74,
        [Description("Beijo da Sorte")]
        FORTUNEKISS = 76,
        [Description("Dança Cigana")]
        SERVICEFORYOU = 77,
        [Description("Holofote")]
        SPOTLIGHT = 2226,
        [Description("Dança com Lobos")]
        DANCE_WITH_WUG = 441, 
        [Description("Sinfonia dos Ventos")]
        RUSH_WINDMILL = 442,
        [Description("Serenata ao Luar")]
        MOONLIT_SERENADE = 447,
        [Description("Dragão Ascendente")]
        RAISINGDRAGON = 410,
        [Description("Firm Faith")]
        FIRM_FAITH = 1162,
        [Description("Powerful Faith")]
        POWERFUL_FAITH = 1160,
        [Description("Chakra do Vigor")]
        GENTLETOUCH_REVITALIZE = 427,
        [Description("Chakra da Fúria")]
        GENTLETOUCH_CHANGE = 426,
        [Description("Propulsão do Carrinho")]
        GN_CARTBOOST = 461,
        [Description("Reflexo de Combate")]
        WEAPONBLOCKING = 337,
        [Description("Canção de Frigga")]
        FRIGG_SONG = 715,
        [Description("Research Report")]
        RESEARCHREPORT = 1248,
        [Description("Resistência Final")]
        MADNESSCANCEL = 203,
        [Description("Pânico do Justiceiro")]
        ADJUSTMENT = 209,
        [Description("Aumentar Precisão")]
        ACCURACY = 210,
        [Description("Fúria Interior")]
        FURY = 86,
        [Description("Impositio Manus")]
        IMPOSITIO = 15,
        [Description("Reação Ilimitada")]
        E_CHAIN = 753,
        [Description("Desejo das Sombras")]
        AUTOSHADOWSPELL = 393,
        [Description("Furtividade")]
        CLOAKING = 5,
        [Description("Esconderijo")]
        HIDING = 4,
        [Description("Impacto Explosivo")]
        MAGNUM = 131,
        [Description("Aura de Combate")]
        FIGHTINGSPIRIT = 322,
        [Description("Basílica")]
        BASILICA = 1122,
        [Description("Renovatio")]
        RENOVATIO = 336,
        [Description("Distorção Arcana")]
        STASIS = 356,
        [Description("Proteção Química Total")]
        FULLPROTECTION = 2045,
        [Description("Bala Mágica")]
        MAGICAL_BULLET = 966,
        [Description("Justa")]
        JUSTA = 2189,
        [Description("Mestre dos Elementos")]
        ELEMENT_MASTER = 2182,
        [Description("Adaga de Arremesso")]
        BOOMERANG_DAGGER = 2174,
        [Description("Banho de Toxinas")]
        POISON_SHOWER = 2186,
        [Description("Punho Embriagado")]
        DRUNK_PUNCH = 2198,
        [Description("Estilo Yin/Yang")]
        YINYANG_STYLE = 2197,
        [Description("Superaquecimento")]
        OVERHEATING = 2180,
        [Description("Clone das Sombras")]
        SHADOW_CLONE = 2196,
        [Description("Planta Sanguessuga")]
        BLOOD_SUCKER_PLANT = 464,
        [Description("Projeção Espiritual")]
        SOUL_PROJECTION = 2193,
        [Description("Maestria Arcana")]
        RECOGNIZEDSPELL = 355,
        [Description("Cambalhota")]
        DODGE_ON = 143,
        [Description("Inspiração")]
        IZAYOI = 652,
        [Description("Imagem Falsa")]
        BUNSINJYUTSU = 207,
        TARGET_BLOOD = 301,
        [Description("Divina Providência")]
        PROVIDENCE = 61,
        [Description("União Solar, Lunar e Estelar")]
        FUSION = 2063,
        [Description("Bater em Retirada")]
        HOM_AVOID = 192,
        [Description("Kaupe")]
        KAUPE = 158,
        [Description("Kaite")]
        KAITE = 1402,
        [Description("Kaizel")]
        KAIZEL = 156,
        [Description("Kaahi")]
        KAAHI = 157,
        [Description("Espreitar")]
        CHASEWALK = 182,
        [Description("Enlouquecedor")]
        MINDBREAKER = 126,
        [Description("Corrida")]
        RUN = 145,
        [Description("Arsenal")]
        ARSENAL = 2242,
        [Description("Rapsódia Improvisada")]
        STAGE_HARMONY = 2075, // verificar o ID correto
        [Description("Escudo de Fé")]
        FAITH_SHIELD = 2220,
        [Description("Poção da Fúria Química")]
        CHEMICAL_FURY_POTION = 2235,
        [Description("Benção do Devoto")]
        BLESSING_DEVOTEE = 5034,
        [Description("Modo Sennin")]
        SENNIN_MODE = 2241,
        [Description("Cólera do Dragão")]
        DRAGONS_WRATH = 2238,
        [Description("Ascensão Espiritual")]
        SPIRITUAL_ASCENSION = 2240,
        [Description("Furor")]
        HEAT_BARREL = 759,


        //ELEMENTAL CONVERTERS
        [Description("Conversor Elemental Fogo")]
        PROPERTYFIRE = 90,
        [Description("Conversor Elemental Água")]
        PROPERTYWATER = 91,
        [Description("Conversor Elemental Vento")]
        PROPERTYWIND = 92,
        [Description("Conversor Elemental Terra")]
        PROPERTYGROUND = 93,
        [Description("Conversor Elemental Sombrio")]
        PROPERTYDARK = 146,
        [Description("Conversor Elemental Fantasma")]
        PROPERTYTELEKINESIS = 148,
        WEAPONPROPERTY = 64,
        [Description("Conversor Elemental Sagrado")]
        ASPERSIO = 17,
        
        
        //POTIONS
        [Description("Poção da Concentração")]
        CONCENTRATION_POTION = 37,
        [Description("Poção do Despertar")]
        AWAKENING_POTION = 38,
        [Description("Poção da Fúria Selvagem")]
        BERSERK_POTION = 39,
        [Description("Poção de Agilidade Dourada")]
        ASPDPOTIONINFINITY = 40,
        [Description("Elixir Rubro")]
        RED_BOOSTER = 664,
        [Description("Elixir Ultra Milagroso")]
        ALMIGHTY = 9004,
        [Description("Poção de Regeneração")]
        REGENERATION_POTION = 292,
        [Description("Abrasivo")]
        CRITICALPERCENT = 295,
        [Description("Bala de Guaraná")]
        GUARANA = 9006,
        [Description("Suco de Gato")]
        SPELLBREAKER = 300,
        [Description("Salada de Frutas Tropicais")]
        HALOHALO = 2011,
        GLASS_OF_ILLUSION = 296,
        [Description("Poção Mental")]
        MENTAL_POTION = 298,
        [Description("Poção Vitata")]
        VITATA_POTION = 483,
        [Description("Poção do Bovino Furioso")]
        BOVINE = 2068,
        [Description("Poção do Dragão Místico")]
        DRAGON = 2069,
        [Description("Poção do Leviathan")]
        LEVIATHAN = 2070,
        [Description("Pílula de Combate")]
        COMBAT_PILL = 662,
        [Description("Poção Grande de HP")]
        HP_INCREASE_POTION_LARGE = 480,
        [Description("Poção Grande de SP")]
        SP_INCREASE_POTION_LARGE = 481,
        [Description("Suco Celular Enriquecido")]
        ENRICH_CELERMINE_JUICE = 484,
        [Description("Ativador de Erva Vermelha")]
        RED_HERB_ACTIVATOR = 1170,
        [Description("Ativador de Erva Azul")]
        BLUE_HERB_ACTIVATOR = 1171,
        [Description("Poção X Dourada")]
        REF_T_POTION = 1169,
        [Description("Super Poção Ilimitada")]
        LIMIT_POWER_BOOSTER = 867,
        [Description("Poção do Furor Físico")]
        FULL_SWINGK = 486,
        [Description("Poção do Furor Mágico")]
        MANA_PLUS = 487,


        //FOODS
        FOOD_STR = 241,
        FOOD_AGI = 242,
        FOOD_VIT = 243,
        FOOD_DEX = 244,
        FOOD_INT = 245,
        FOOD_LUK = 246,
        FOOD_VIT_CASH = 273,
        STR_Biscuit_Stick = 2035,
        VIT_Biscuit_Stick = 2036,
        AGI_Biscuit_Stick = 2037,
        INT_Biscuit_Stick = 2038,
        DEX_Biscuit_Stick = 2039,
        LUK_Biscuit_Stick = 2040,
        [Description("Acarajé")]
        ACARAJE = 414,


        //BOXES
        [Description("Caixa da Sonolência")]
        DROWSINESS_BOX = 151,
        [Description("Caixa do Ressentimento")]
        RESENTMENT_BOX = 150,
        [Description("Caixa da Luz do Sol")]
        SUNLIGHT_BOX = 184,
        [Description("Caixa do Trovão")]
        BOX_OF_THUNDER = 289,
        [Description("Poção do Vento")]
        SPEED_POT = 41,


        //ELEMENTAL RESISTANCES
        [Description("Poção Anti-Água")]
        RESIST_PROPERTY_WATER = 908,
        [Description("Poção Anti-Terra")]
        RESIST_PROPERTY_GROUND = 909,
        [Description("Poção Anti-Fogo")]
        RESIST_PROPERTY_FIRE = 910,
        [Description("Poção Anti-Vento")]
        RESIST_PROPERTY_WIND = 911,
        

        //SCROLLS
        [Description("Aumentar Agilidade")]
        INC_AGI = 12,
        [Description("Bênção")]
        BLESSING = 10,
        [Description("Pergaminho de Esquiva")]
        FLEE_SCROLL = 247,
        [Description("Pergaminho de Precisão")]
        ACCURACY_SCROLL = 248,
        [Description("Pergaminho do Éden")]
        EDEN = 9999,


        //3RD FOODS
        STR_3RD_FOOD = 491,
        INT_3RD_FOOD = 492,
        VIT_3RD_FOOD = 493,
        DEX_3RD_FOOD = 494,
        AGI_3RD_FOOD = 495,
        LUK_3RD_FOOD = 496,


        //Rune Knight Runes
        //OTHILA = 322,
        HAGALAZ = 320,
        THURISAZ = 319,
        LUX_AMINA = 1154,


        //STATUS
        QUAGMIRE = 8,
        HALLUCINATIONWALK = 334,


        //OTHERS
        [Description("50% Acima do Peso")]
        OVERWEIGHT = 35,
        [Description("Acesso VIP")]
        VIP_ACCESS = 973,
        [Description("Anel do Treinador")]
        COACHS_RING = 2024,
        [Description("Anti-Bot")]
        ANTI_BOT = 5020,
        [Description("Botas de Atlas")]
        ATLAS_BOOTS = 2031,
        [Description("Flecha Dourada")]
        GOLDEN_ARROW = 695,
        [Description("Força Heróica")]
        HEROIC_FORCE = 5060,
        [Description("Goma de Mascar")]
        CASH_RECEIVEITEM = 252,
        [Description("Instância Competitiva")]
        COMPETITIVE_INSTANCE = 5019,
        [Description("Manual de Combate")]
        CASH_PLUSEXP = 1400,
        [Description("Manual de Combate de Classe")]
        CASH_PLUSECLASSXP = 312,
        [Description("Rédeas")]
        RIDDING = 613,
        [Description("Relógio Rekenber")]
        REKENBER_WATCH = 2027,
        [Description("Sentar")]
        SIT = 622,


        // DEBUFFS
        [Description("Sangramento")]
        BLEEDING = 124,
        [Description("Cegueira")]
        BLIND = 887,
        [Description("Incêncio")]
        BURNING = 881,
        [Description("Confusão/Caos")]
        CONFUSION = 886,
        [Description("Ferimento Crítico")]
        CRITICALWOUND = 286,
        [Description("Cristalização")]
        CRYSTALIZE = 9999, // Verificar o ID correto
        [Description("Maldição")]
        CURSE = 884,
        [Description("Envenenamento Mortal")]
        DEADLY_POISON = 285,
        [Description("Diminuir Agilidade")]
        DECREASE_AGI = 13,
        [Description("Sono Profundo")]
        DEEP_SLEEP = 435,
        [Description("Medo")]
        FEAR = 891,
        [Description("Hipotermia")]
        FREEZING = 351,
        [Description("Congelamento")]
        FROZEN = 876,
        [Description("Alucinação")]
        HALLUCINATION = 34,
        [Description("Grito da Mandrágora")]
        MANDRAGORA = 470,
        [Description("Envenenamento")]
        POISON = 883,
        [Description("Silêncio")]
        SILENCE = 885,
        [Description("Sono")]
        SLEEP = 878,
        [Description("Conjuração Lenta")]
        SLOW_CAST = 282,
        [Description("Petrificação")]
        STONE = 875,
        [Description("Atordoamento")]
        STUN = 877,
        [Description("Zumbificação")]
        UNDEAD = 97,


        // Pergaminhos Cheffenia
        [Description("Pergaminho de Ghostring")]
        GHOSTRING = 302,
        [Description("Pergaminho de Angeling")]
        ANGELING = 303,
        [Description("Pergaminho de Tao Gunka")]
        TAO_GUNKA = 368,
        [Description("Pergaminho de Senhor dos Orcs")]
        SR_ORCS = 371,
        [Description("Pergaminho de Orc Herói")]
        ORC_HEROI = 370,
        [Description("Pergaminho de Abelha Rainha")]
        ABELHA = 369,
        
    }
}
