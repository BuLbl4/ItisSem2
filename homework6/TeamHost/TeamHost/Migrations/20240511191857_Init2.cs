using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamHost.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1L, "strategy", "Стратегии", "Strategy" },
                    { 2L, "adventure", "Приключенческие игры", "Adventure" },
                    { 3L, "horror", "Страшные игры", "Horror" },
                    { 4L, "simulator", "Симулятор", "Simulator" },
                    { 5L, "fighting", "Файтинг", "Fighting" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2", "Alpha3", "Code", "Fullname", "Name" },
                values: new object[,]
                {
                    { 1L, "AU", "AUS", 36L, "АВСТРАЛИЯ", "АВСТРАЛИЯ" },
                    { 2L, "AT", "AUT", 40L, "АВСТРИЙСКАЯ РЕСПУБЛИКА", "АВСТРИЯ" },
                    { 3L, "AZ", "AZE", 31L, "РЕСПУБЛИКА АЗЕРБАЙДЖАН", "АЗЕРБАЙДЖАН" },
                    { 4L, "AL", "ALB", 8L, "РЕСПУБЛИКА АЛБАНИЯ", "АЛБАНИЯ" },
                    { 5L, "DZ", "DZA", 12L, "АЛЖИРСКАЯ НАРОДНАЯ ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА", "АЛЖИР" },
                    { 6L, "AI", "AIA", 660L, "АНГИЛЬЯ", "АНГИЛЬЯ" },
                    { 7L, "AO", "AGO", 24L, "РЕСПУБЛИКА АНГОЛА", "АНГОЛА" },
                    { 8L, "AD", "AND", 20L, "КНЯЖЕСТВО АНДОРРА", "АНДОРРА" },
                    { 9L, "AQ", "ATA", 10L, "АНТАРКТИДА", "АНТАРКТИДА" },
                    { 10L, "AG", "ATG", 28L, "АНТИГУА И БАРБУДА", "АНТИГУА И БАРБУДА" },
                    { 11L, "AR", "ARG", 32L, "АРГЕНТИНСКАЯ РЕСПУБЛИКА", "АРГЕНТИНА" },
                    { 12L, "AM", "ARM", 51L, "РЕСПУБЛИКА АРМЕНИЯ", "АРМЕНИЯ" },
                    { 13L, "AW", "ABW", 533L, "ОСТРОВ АРУБА", "АРУБА" },
                    { 14L, "AF", "AFG", 4L, "ПЕРЕХОДНОЕ ИСЛАМСКОЕ ГОСУДАРСТВО АФГАНИСТАН", "АФГАНИСТАН" },
                    { 15L, "BS", "BHS", 44L, "СОДРУЖЕСТВО БАГАМЫ", "БАГАМЫ" },
                    { 16L, "BD", "BGD", 50L, "НАРОДНАЯ РЕСПУБЛИКА БАНГЛАДЕШ", "БАНГЛАДЕШ" },
                    { 17L, "BB", "BRB", 52L, "БАРБАДОС", "БАРБАДОС" },
                    { 18L, "BH", "BHR", 48L, "КОРОЛЕВСТВО БАХРЕЙН", "БАХРЕЙН" },
                    { 19L, "BY", "BLR", 112L, "РЕСПУБЛИКА БЕЛАРУСЬ", "БЕЛАРУСЬ" },
                    { 20L, "BZ", "BLZ", 84L, "БЕЛИЗ", "БЕЛИЗ" },
                    { 21L, "BE", "BEL", 56L, "КОРОЛЕВСТВО БЕЛЬГИИ", "БЕЛЬГИЯ" },
                    { 22L, "BJ", "BEN", 204L, "РЕСПУБЛИКА БЕНИН", "БЕНИН" },
                    { 23L, "BM", "BMU", 60L, "БЕРМУДСКИЕ ОСТРОВА", "БЕРМУДЫ" },
                    { 24L, "BG", "BGR", 100L, "РЕСПУБЛИКА БОЛГАРИЯ", "БОЛГАРИЯ" },
                    { 25L, "BO", "BOL", 68L, "РЕСПУБЛИКА БОЛИВИЯ", "БОЛИВИЯ" },
                    { 26L, "BA", "BIH", 70L, "БОСНИЯ И ГЕРЦЕГОВИНА", "БОСНИЯ И ГЕРЦЕГОВИНА" },
                    { 27L, "BW", "BWA", 72L, "РЕСПУБЛИКА БОТСВАНА", "БОТСВАНА" },
                    { 28L, "BR", "BRA", 76L, "ФЕДЕРАТИВНАЯ РЕСПУБЛИКА БРАЗИЛИЯ", "БРАЗИЛИЯ" },
                    { 29L, "IO", "IOT", 86L, "БРИТАНСКАЯ ТЕРРИТОРИЯ В ИНДИЙСКОМ ОКЕАНЕ (БРИТ.)", "БРИТАН. ТЕРРИТ." },
                    { 30L, "BN", "BRN", 96L, "БРУНЕЙ-ДАРУССАЛАМ", "БРУНЕЙ" },
                    { 31L, "BV", "BVT", 74L, "ОСТРОВ БУВЕ", "БУВЕ" },
                    { 32L, "BF", "BFA", 854L, "БУРКИНА-ФАСО", "БУРКИНА-ФАСО" },
                    { 33L, "BI", "BDI", 108L, "РЕСПУБЛИКА БУРУНДИ", "БУРУНДИ" },
                    { 34L, "BT", "BTN", 64L, "КОРОЛЕВСТВО БУТАН", "БУТАН" },
                    { 35L, "VU", "VUT", 548L, "РЕСПУБЛИКА ВАНУАТУ", "ВАНУАТУ" },
                    { 36L, "VA", "VAT", 336L, "ПАПСКИЙ ПРЕСТОЛ (ГОСУДАРСТВО-ГОРОД ВАТИКАН)", "ВАТИКАН" },
                    { 37L, "HU", "HUN", 348L, "ВЕНГЕРСКАЯ РЕСПУБЛИКА", "ВЕНГРИЯ" },
                    { 38L, "VE", "VEN", 862L, "БОЛИВАРИЙСКАЯ РЕСПУБЛИКА ВЕНЕСУЭЛА", "ВЕНЕСУЭЛА" },
                    { 39L, "VI", "VIR", 850L, "ВИРГИНСКИЕ ОСТРОВА (США)", "ВИРГИН. О-ВА" },
                    { 40L, "VG", "VGB", 92L, "БРИТАНСКИЕ ВИРГИНСКИЕ ОСТРОВА", "ВИРГИН. О-ВА, БРИТАНСКИЕ" },
                    { 41L, "AS", "ASM", 16L, "АМЕРИКАНСКОЕ САМОА (США)", "ВОСТОЧНОЕ САМОА" },
                    { 42L, "VN", "VNM", 704L, "СОЦИАЛИСТИЧЕСКАЯ РЕСПУБЛИКА ВЬЕТНАМ", "ВЬЕТНАМ" },
                    { 43L, "GA", "GAB", 266L, "ГАБОНСКАЯ РЕСПУБЛИКА", "ГАБОН" },
                    { 44L, "HT", "HTI", 332L, "РЕСПУБЛИКА ГАИТИ", "ГАИТИ" },
                    { 45L, "GY", "GUY", 328L, "РЕСПУБЛИКА ГАЙАНА", "ГАЙАНА" },
                    { 46L, "GM", "GMB", 270L, "РЕСПУБЛИКА ГАМБИЯ", "ГАМБИЯ" },
                    { 47L, "GH", "GHA", 288L, "РЕСПУБЛИКА ГАНА", "ГАНА" },
                    { 48L, "GP", "GLP", 312L, "ГВАДЕЛУПА (ФР.)", "ГВАДЕЛУПА" },
                    { 49L, "GT", "GTM", 320L, "РЕСПУБЛИКА ГВАТЕМАЛА", "ГВАТЕМАЛА" },
                    { 50L, "GF", "GUF", 254L, "ФРАНЦУЗСКАЯ ГВИАНА (ФР.)", "ГВИАНА" },
                    { 51L, "GN", "GIN", 324L, "ГВИНЕЙСКАЯ РЕСПУБЛИКА", "ГВИНЕЯ" },
                    { 52L, "GW", "GNB", 624L, "РЕСПУБЛИКА ГВИНЕЯ-БИСАУ", "ГВИНЕЯ-БИСАУ" },
                    { 53L, "DE", "DEU", 276L, "ФЕДЕРАТИВНАЯ РЕСПУБЛИКА ГЕРМАНИЯ", "ГЕРМАНИЯ" },
                    { 54L, "GG", "GGY", 831L, "ГЕРНСИ", "ГЕРНСИ" },
                    { 55L, "GI", "GIB", 292L, "ГИБРАЛТАР (БРИТ.)", "ГИБРАЛТАР" },
                    { 56L, "HN", "HND", 340L, "РЕСПУБЛИКА ГОНДУРАС", "ГОНДУРАС" },
                    { 57L, "HK", "HKG", 344L, "СПЕЦИАЛЬНЫЙ АДМИНИСТРАТИВНЫЙ РЕГИОН КИТАЯ ГОНКОНГ", "ГОНКОНГ" },
                    { 58L, "GD", "GRD", 308L, "ГРЕНАДА", "ГРЕНАДА" },
                    { 59L, "GL", "GRL", 304L, "ГРЕНЛАНДИЯ", "ГРЕНЛАНДИЯ" },
                    { 60L, "GR", "GRC", 300L, "ГРЕЧЕСКАЯ РЕСПУБЛИКА", "ГРЕЦИЯ" },
                    { 61L, "GE", "GEO", 268L, "РЕСПУБЛИКА ГРУЗИЯ", "ГРУЗИЯ" },
                    { 62L, "GU", "GUM", 316L, "ГУАМ (США)", "ГУАМ" },
                    { 63L, "DK", "DNK", 208L, "КОРОЛЕВСТВО ДАНИЯ", "ДАНИЯ" },
                    { 64L, "JE", "JEY", 832L, "ДЖЕРСИ", "ДЖЕРСИ" },
                    { 65L, "DJ", "DJI", 262L, "РЕСПУБЛИКА ДЖИБУТИ", "ДЖИБУТИ" },
                    { 66L, "DM", "DMA", 212L, "СОДРУЖЕСТВО ДОМИНИКИ", "ДОМИНИКА" },
                    { 67L, "DO", "DOM", 214L, "ДОМИНИКАНСКАЯ РЕСПУБЛИКА", "ДОМИНИКАНСКАЯ РЕСПУБЛИКА" },
                    { 68L, "EG", "EGY", 818L, "АРАБСКАЯ РЕСПУБЛИКА ЕГИПЕТ (АРЕ)", "ЕГИПЕТ" },
                    { 69L, "ZM", "ZMB", 894L, "РЕСПУБЛИКА ЗАМБИЯ", "ЗАМБИЯ" },
                    { 70L, "EH", "ESH", 732L, "ЗАПАДНАЯ САХАРА", "ЗАПАДНАЯ САХАРА" },
                    { 71L, "ZW", "ZWE", 716L, "РЕСПУБЛИКА ЗИМБАБВЕ", "ЗИМБАБВЕ" },
                    { 72L, "IL", "ISR", 376L, "ГОСУДАРСТВО ИЗРАИЛЬ", "ИЗРАИЛЬ" },
                    { 73L, "IN", "IND", 356L, "РЕСПУБЛИКА ИНДИЯ", "ИНДИЯ" },
                    { 74L, "ID", "IDN", 360L, "РЕСПУБЛИКА ИНДОНЕЗИЯ", "ИНДОНЕЗИЯ" },
                    { 75L, "JO", "JOR", 400L, "ИОРДАНСКОЕ ХАШИМИТСКОЕ КОРОЛЕВСТВО", "ИОРДАНИЯ" },
                    { 76L, "IQ", "IRQ", 368L, "РЕСПУБЛИКА ИРАК", "ИРАК" },
                    { 77L, "IR", "IRN", 364L, "ИСЛАМСКАЯ РЕСПУБЛИКА ИРАН", "ИРАН" },
                    { 78L, "IE", "IRL", 372L, "ИРЛАНДИЯ", "ИРЛАНДИЯ" },
                    { 79L, "IS", "ISL", 352L, "РЕСПУБЛИКА ИСЛАНДИЯ", "ИСЛАНДИЯ" },
                    { 80L, "ES", "ESP", 724L, "КОРОЛЕВСТВО ИСПАНИЯ", "ИСПАНИЯ" },
                    { 81L, "IT", "ITA", 380L, "ИТАЛЬЯНСКАЯ РЕСПУБЛИКА", "ИТАЛИЯ" },
                    { 82L, "YE", "YEM", 887L, "ЙЕМЕНСКАЯ РЕСПУБЛИКА", "ЙЕМЕН" },
                    { 83L, "CV", "CPV", 132L, "РЕСПУБЛИКА КАБО-ВЕРДЕ", "КАБО-ВЕРДЕ" },
                    { 84L, "KZ", "KAZ", 398L, "РЕСПУБЛИКА КАЗАХСТАН", "КАЗАХСТАН" },
                    { 85L, "KY", "CYM", 136L, "ОСТРОВА КАЙМАН", "КАЙМАН" },
                    { 86L, "KH", "KHM", 116L, "КОРОЛЕВСТВО КАМБОДЖА", "КАМБОДЖА" },
                    { 87L, "CM", "CMR", 120L, "РЕСПУБЛИКА КАМЕРУН", "КАМЕРУН" },
                    { 88L, "CA", "CAN", 124L, "КАНАДА", "КАНАДА" },
                    { 89L, "QA", "QAT", 634L, "ГОСУДАРСТВО КАТАР", "КАТАР" },
                    { 91L, "KE", "KEN", 404L, "РЕСПУБЛИКА КЕНИЯ", "КЕНИЯ" },
                    { 92L, "CY", "CYP", 196L, "РЕСПУБЛИКА КИПР", "КИПР" },
                    { 93L, "KI", "KIR", 296L, "РЕСПУБЛИКА КИРИБАТИ", "КИРИБАТИ" },
                    { 94L, "CN", "CHN", 156L, "КИТАЙСКАЯ НАРОДНАЯ РЕСПУБЛИКА (КНР)", "КИТАЙ" },
                    { 95L, "CC", "CCK", 166L, "КОКОСОВЫЕ (КИЛИНГ) ОСТРОВА", "КОКОСОВЫЕ О-ВА" },
                    { 96L, "CO", "COL", 170L, "РЕСПУБЛИКА КОЛУМБИЯ", "КОЛУМБИЯ" },
                    { 97L, "KM", "COM", 174L, "СОЮЗ КОМОРЫ", "КОМОРЫ" },
                    { 98L, "CG", "COG", 178L, "РЕСПУБЛИКА КОНГО", "КОНГО" },
                    { 99L, "CD", "COD", 180L, "ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА КОНГО", "КОНГО" },
                    { 100L, "KR", "KOR", 410L, "РЕСПУБЛИКА КОРЕЯ", "КОРЕЯ" },
                    { 101L, "KP", "PRK", 408L, "КОРЕЙСКАЯ НАРОДНО-ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА", "КОРЕЯ (КНДР)" },
                    { 102L, "CR", "CRI", 188L, "РЕСПУБЛИКА КОСТА-РИКА", "КОСТА-РИКА" },
                    { 103L, "CI", "CIV", 384L, "РЕСПУБЛИКА КОТ Д'ИВУАР'", "КОТ Д'ИВУАР'" },
                    { 104L, "CU", "CUB", 192L, "РЕСПУБЛИКА КУБА", "КУБА" },
                    { 105L, "KW", "KWT", 414L, "ГОСУДАРСТВО КУВЕЙТ", "КУВЕЙТ" },
                    { 106L, "KG", "KGZ", 417L, "РЕСПУБЛИКА КЫРГЫЗСТАН", "КЫРГЫЗСТАН" },
                    { 107L, "LA", "LAO", 418L, "ЛАОССКАЯ НАРОДНО-ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА", "ЛАОС" },
                    { 108L, "LV", "LVA", 428L, "ЛАТВИЙСКАЯ РЕСПУБЛИКА", "ЛАТВИЯ" },
                    { 109L, "LS", "LSO", 426L, "КОРОЛЕВСТВО ЛЕСОТО", "ЛЕСОТО" },
                    { 110L, "LR", "LBR", 430L, "РЕСПУБЛИКА ЛИБЕРИЯ", "ЛИБЕРИЯ" },
                    { 111L, "LB", "LBN", 422L, "ЛИВАНСКАЯ РЕСПУБЛИКА", "ЛИВАН" },
                    { 112L, "LY", "LBY", 434L, "СОЦИАЛИСТИЧЕСКАЯ НАРОДНАЯ ЛИВИЙСКАЯ АРАБСКАЯ ДЖАМАХИРИЯ", "ЛИВИЯ" },
                    { 113L, "LT", "LTU", 440L, "ЛИТОВСКАЯ РЕСПУБЛИКА", "ЛИТВА" },
                    { 114L, "LI", "LIE", 438L, "КНЯЖЕСТВО ЛИХТЕНШТЕЙН", "ЛИХТЕНШТЕЙН" },
                    { 115L, "LU", "LUX", 442L, "ВЕЛИКОЕ ГЕРЦОГСТВО ЛЮКСЕМБУРГ", "ЛЮКСЕМБУРГ" },
                    { 116L, "MU", "MUS", 480L, "РЕСПУБЛИКА МАВРИКИЙ", "МАВРИКИЙ" },
                    { 117L, "MR", "MRT", 478L, "ИСЛАМСКАЯ РЕСПУБЛИКА МАВРИТАНИЯ", "МАВРИТАНИЯ" },
                    { 118L, "MG", "MDG", 450L, "ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА МАДАГАСКАР", "МАДАГАСКАР" },
                    { 119L, "YT", "MYT", 175L, "МАЙОТТА", "МАЙОТТА" },
                    { 120L, "MO", "MAC", 446L, "СПЕЦИАЛЬНЫЙ АДМИНИСТРАТИВНЫЙ РЕГИОН КИТАЯ МАКАО", "МАКАО" },
                    { 121L, "MK", "MKD", 807L, "РЕСПУБЛИКА МАКЕДОНИЯ", "МАКЕДОНИЯ" },
                    { 122L, "MW", "MWI", 454L, "РЕСПУБЛИКА МАЛАВИ", "МАЛАВИ" },
                    { 123L, "MY", "MYS", 458L, "МАЛАЙЗИЯ", "МАЛАЙЗИЯ" },
                    { 124L, "ML", "MLI", 466L, "РЕСПУБЛИКА МАЛИ", "МАЛИ" },
                    { 125L, "UM", "UMI", 581L, "МАЛЫЕ ТИХООКЕАНСКИЕ ОТДАЛЕННЫЕ ОСТРОВА (США)", "МАЛЫЕ ТИХООК. ОСТРОВА (США)" },
                    { 126L, "MV", "MDV", 462L, "МАЛЬДИВСКАЯ РЕСПУБЛИКА", "МАЛЬДИВЫ" },
                    { 127L, "MT", "MLT", 470L, "РЕСПУБЛИКА МАЛЬТА", "МАЛЬТА" },
                    { 128L, "MP", "MNP", 580L, "СОДРУЖЕСТВО СЕВЕРНЫХ МАРИАНСКИХ ОСТРОВОВ", "МАРИАНСКИЕ ОСТРОВА" },
                    { 129L, "MA", "MAR", 504L, "КОРОЛЕВСТВО МАРОККО", "МАРОККО" },
                    { 130L, "MQ", "MTQ", 474L, "МАРТИНИКА (ФР.)", "МАРТИНИКА" },
                    { 131L, "MH", "MHL", 584L, "РЕСПУБЛИКА МАРШАЛЛОВЫ ОСТРОВА", "МАРШАЛЛОВЫ ОСТРОВА" },
                    { 132L, "MX", "MEX", 484L, "МЕКСИКАНСКИЕ СОЕДИНЕННЫЕ ШТАТЫ", "МЕКСИКА" },
                    { 133L, "FM", "FSM", 583L, "ФЕДЕРАТИВНЫЕ ШТАТЫ МИКРОНЕЗИИ", "МИКРОНЕЗИЯ" },
                    { 134L, "MZ", "MOZ", 508L, "РЕСПУБЛИКА МОЗАМБИК", "МОЗАМБИК" },
                    { 135L, "MD", "MDA", 498L, "РЕСПУБЛИКА МОЛДОВА", "МОЛДОВА" },
                    { 136L, "MC", "MCO", 492L, "КНЯЖЕСТВО МОНАКО", "МОНАКО" },
                    { 137L, "MN", "MHG", 496L, "МОНГОЛИЯ", "МОНГОЛИЯ" },
                    { 138L, "MS", "MSR", 500L, "МОНТСЕРРАТ (БРИТ.)", "МОНТСЕРРАТ" },
                    { 139L, "MM", "MMR", 104L, "СОЮЗ МЬЯНМА", "МЬЯНМА" },
                    { 140L, "NA", "NAM", 516L, "РЕСПУБЛИКА НАМИБИЯ", "НАМИБИЯ" },
                    { 141L, "NR", "NRU", 520L, "РЕСПУБЛИКА НАУРУ", "НАУРУ" },
                    { 142L, "NP", "NPL", 524L, "КОРОЛЕВСТВО НЕПАЛ", "НЕПАЛ" },
                    { 143L, "NE", "NER", 562L, "РЕСПУБЛИКА НИГЕР", "НИГЕР" },
                    { 144L, "NG", "NGA", 566L, "ФЕДЕРАТИВНАЯ РЕСПУБЛИКА НИГЕРИЯ", "НИГЕРИЯ" },
                    { 145L, "AN", "ANT", 530L, "НИДЕРЛАНДСКИЕ АНТИЛЫ", "НИДЕРЛАНДСКИЕ АНТИЛЫ" },
                    { 146L, "NL", "NLD", 528L, "КОРОЛЕВСТВО НИДЕРЛАНДЫ", "НИДЕРЛАНДЫ" },
                    { 147L, "NI", "NIC", 558L, "РЕСПУБЛИКА НИКАРАГУА", "НИКАРАГУА" },
                    { 148L, "NU", "NIU", 570L, "РЕСПУБЛИКА НИУЭ", "НИУЭ" },
                    { 149L, "NZ", "NZL", 554L, "НОВАЯ ЗЕЛАНДИЯ", "НОВАЯ ЗЕЛАНДИЯ" },
                    { 150L, "NC", "NCL", 540L, "НОВАЯ КАЛЕДОНИЯ", "НОВАЯ КАЛЕДОНИЯ" },
                    { 151L, "NO", "NOR", 578L, "КОРОЛЕВСТВО НОРВЕГИЯ", "НОРВЕГИЯ" },
                    { 152L, "NF", "NFK", 574L, "ОСТРОВ НОРФОЛК", "НОРФОЛК" },
                    { 153L, "AE", "ARE", 784L, "ОБЪЕДИНЕННЫЕ АРАБСКИЕ ЭМИРАТЫ", "ОБЪЕД. АРАБСКИЕ ЭМИРАТЫ" },
                    { 154L, "IM", "IMY", 833L, "ОСТРОВ МЭН", "О-В МЭН" },
                    { 155L, "CX", "CXR", 162L, "ОСТРОВ РОЖДЕСТВА (АВСТРАЛ.)", "О-В РОЖДЕСТВА" },
                    { 156L, "СК", "COK", 184L, "ОСТРОВА КУКА (Н. ЗЕЛ.)", "О-ВА КУКА" },
                    { 157L, "OM", "OMN", 512L, "СУЛТАНАТ ОМАН", "ОМАН" },
                    { 158L, "PK", "PAK", 586L, "ИСЛАМСКАЯ РЕСПУБЛИКА ПАКИСТАН", "ПАКИСТАН" },
                    { 159L, "PW", "PLW", 585L, "РЕСПУБЛИКА ПАЛАУ", "ПАЛАУ" },
                    { 160L, "PS", "PSE", 275L, "ОККУПИРОВАННАЯ ПАЛЕСТИНСКАЯ ТЕРРИТОРИЯ", "ПАЛЕСТИНСКАЯ ТЕРРИТОРИЯ, ОККУПИРОВАННАЯ" },
                    { 161L, "PA", "PAN", 591L, "РЕСПУБЛИКА ПАНАМА", "ПАНАМА" },
                    { 162L, "PG", "PNG", 598L, "ПАПУА - НОВАЯ ГВИНЕЯ", "ПАПУА - НОВАЯ ГВИНЕЯ" },
                    { 163L, "PY", "PRY", 600L, "РЕСПУБЛИКА ПАРАГВАЙ", "ПАРАГВАЙ" },
                    { 164L, "PE", "PER", 604L, "РЕСПУБЛИКА ПЕРУ", "ПЕРУ" },
                    { 165L, "PN", "PCN", 612L, "ПИТКЭРН (БРИТ.)", "ПИТКЭРН" },
                    { 166L, "PL", "POL", 616L, "РЕСПУБЛИКА ПОЛЬША", "ПОЛЬША" },
                    { 167L, "PT", "PRT", 620L, "ПОРТУГАЛЬСКАЯ РЕСПУБЛИКА", "ПОРТУГАЛИЯ" },
                    { 168L, "PR", "PRI", 630L, "ПУЭРТО-РИКО", "ПУЭРТО-РИКО" },
                    { 169L, "RE", "REU", 638L, "РЕЮНЬОН", "РЕЮНЬОН" },
                    { 170L, "RU", "RUS", 643L, "РОССИЙСКАЯ ФЕДЕРАЦИЯ", "РОССИЯ" },
                    { 171L, "RW", "RWA", 646L, "РУАНДИЙСКАЯ РЕСПУБЛИКА", "РУАНДА" },
                    { 172L, "RO", "ROM", 642L, "РУМЫНИЯ", "РУМЫНИЯ" },
                    { 173L, "WS", "WSM", 882L, "НЕЗАВИСИМОЕ ГОСУДАРСТВО САМОА", "САМОА" },
                    { 174L, "ST", "STR", 678L, "ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА САН-ТОМЕ И ПРИНСИПИ", "САН-ТОМЕ И ПРИНСИПИ" },
                    { 175L, "SM", "SMR", 674L, "РЕСПУБЛИКА САН-МАРИНО", "САН-МАРИНО" },
                    { 176L, "SA", "SAU", 682L, "КОРОЛЕВСТВО САУДОВСКАЯ АРАВИЯ", "САУДОВСКАЯ АРАВИЯ" },
                    { 177L, "SZ", "SWZ", 748L, "КОРОЛЕВСТВО СВАЗИЛЕНД", "СВАЗИЛЕНД" },
                    { 178L, "SH", "SHN", 654L, "ОСТРОВ СВЯТОЙ ЕЛЕНЫ (БРИТ.)", "СВЯТАЯ ЕЛЕНА" },
                    { 179L, "SC", "SYC", 690L, "РЕСПУБЛИКА СЕЙШЕЛЫ", "СЕЙШЕЛЫ" },
                    { 180L, "PM", "SPM", 666L, "СЕН-ПЬЕР И МИКЕЛОН (ФР.)", "СЕН-ПЬЕР И МИКЕЛОН" },
                    { 181L, "SN", "SEN", 686L, "РЕСПУБЛИКА СЕНЕГАЛ", "СЕНЕГАЛ" },
                    { 182L, "VC", "VCT", 670L, "СЕНТ-ВИНСЕНТ И ГРЕНАДИНЫ", "СЕНТ-ВИНСЕНТ И ГРЕНАДИНЫ" },
                    { 183L, "KN", "KNA", 659L, "ФЕДЕРАЦИЯ СЕНТ-КИТС (СЕНТ-КРИСТОФЕР) И НЕВИС", "СЕНТ-КИТС И НЕВИС" },
                    { 184L, "LC", "LCA", 662L, "СЕНТ-ЛЮСИЯ", "СЕНТ-ЛЮСИЯ" },
                    { 185L, "RS", "SRB", 688L, "РЕСПУБЛИКА СЕРБИЯ", "СЕРБИЯ" },
                    { 186L, "SG", "SGP", 702L, "РЕСПУБЛИКА СИНГАПУР", "СИНГАПУР" },
                    { 187L, "SY", "SYR", 760L, "СИРИЙСКАЯ АРАБСКАЯ РЕСПУБЛИКА", "СИРИЯ" },
                    { 188L, "SK", "SVK", 703L, "СЛОВАЦКАЯ РЕСПУБЛИКА", "СЛОВАКИЯ" },
                    { 189L, "SI", "SVN", 705L, "РЕСПУБЛИКА СЛОВЕНИЯ", "СЛОВЕНИЯ" },
                    { 190L, "GB", "GBR", 826L, "СОЕДИНЕННОЕ КОРОЛЕВСТВО ВЕЛИКОБРИТАНИИ И СЕВЕРНОЙ ИРЛАНДИИ", "СОЕДИНЕННОЕ КОРОЛЕВСТВО" },
                    { 191L, "SB", "SLB", 90L, "СОЛОМОНОВЫ ОСТРОВА", "СОЛОМОНОВЫ О-ВА" },
                    { 192L, "SO", "SOM", 706L, "СОМАЛИЙСКАЯ РЕСПУБЛИКА", "СОМАЛИ" },
                    { 193L, "SD", "SDN", 736L, "РЕСПУБЛИКА СУДАН", "СУДАН" },
                    { 194L, "SR", "SUR", 740L, "РЕСПУБЛИКА СУРИНАМ", "СУРИНАМ" },
                    { 195L, "US", "USA", 840L, "СОЕДИНЕННЫЕ ШТАТЫ АМЕРИКИ", "США" },
                    { 196L, "SL", "SLE", 694L, "РЕСПУБЛИКА СЬЕРРА-ЛЕОНЕ", "СЬЕРРА-ЛЕОНЕ" },
                    { 197L, "TJ", "TJK", 762L, "РЕСПУБЛИКА ТАДЖИКИСТАН", "ТАДЖИКИСТАН" },
                    { 198L, "TH", "THA", 764L, "КОРОЛЕВСТВО ТАИЛАНД", "ТАИЛАНД" },
                    { 199L, "TW", "TWN", 158L, "ТАЙВАНЬ (В СОСТАВЕ КИТАЯ)", "ТАЙВАНЬ" },
                    { 200L, "TZ", "TZA", 834L, "ОБЪЕДИНЕННАЯ РЕСПУБЛИКА ТАНЗАНИЯ (ОРТ)", "ТАНЗАНИЯ" },
                    { 201L, "TC", "TCA", 796L, "ОСТРОВА ТЕРКС И КАЙКОС (БРИТ.)", "ТЕРКС И КАЙКОС" },
                    { 202L, "TP", "TMP", 626L, "ДЕМОКРАТИЧЕСКАЯ РЕСПУБЛИКА ТИМОР-ЛЕСТЕ", "ТИМОР-ЛЕСТЕ" },
                    { 203L, "TG", "TGO", 768L, "ТОГОЛЕЗСКАЯ РЕСПУБЛИКА", "ТОГО" },
                    { 204L, "TK", "TKL", 772L, "ТОКЕЛАУ (ЮНИОН) (Н. ЗЕЛ.)", "ТОКЕЛАУ" },
                    { 205L, "TO", "TON", 776L, "КОРОЛЕВСТВО ТОНГА", "ТОНГА" },
                    { 206L, "TT", "TTO", 780L, "РЕСПУБЛИКА ТРИНИДАД И ТОБАГО", "ТРИНИДАД И ТОБАГО" },
                    { 207L, "TV", "TUV", 798L, "ТУВАЛУ", "ТУВАЛУ" },
                    { 208L, "TN", "TUN", 788L, "ТУНИССКАЯ РЕСПУБЛИКА", "ТУНИС" },
                    { 209L, "TM", "TKM", 795L, "ТУРКМЕНИСТАН", "ТУРКМЕНИЯ" },
                    { 210L, "TR", "TUR", 792L, "ТУРЕЦКАЯ РЕСПУБЛИКА", "ТУРЦИЯ" },
                    { 211L, "UG", "UGA", 800L, "РЕСПУБЛИКА УГАНДА", "УГАНДА" },
                    { 212L, "UZ", "UZB", 860L, "РЕСПУБЛИКА УЗБЕКИСТАН", "УЗБЕКИСТАН" },
                    { 213L, "UA", "UKR", 804L, "УКРАИНА", "УКРАИНА" },
                    { 214L, "WF", "WLF", 876L, "ОСТРОВА УОЛЛИС И ФУТУНА", "УОЛЛИС И ФУТУНА" },
                    { 215L, "UY", "URY", 858L, "ВОСТОЧНАЯ РЕСПУБЛИКА УРУГВАЙ", "УРУГВАЙ" },
                    { 216L, "FO", "FRO", 234L, "ФАРЕРСКИЕ ОСТРОВА (В СОСТАВЕ ДАНИИ)", "ФАРЕРСКИЕ О-ВА" },
                    { 217L, "FJ", "FJI", 242L, "РЕСПУБЛИКА ОСТРОВОВ ФИДЖИ", "ФИДЖИ" },
                    { 218L, "PH", "PHL", 608L, "РЕСПУБЛИКА ФИЛИППИНЫ", "ФИЛИППИНЫ" },
                    { 219L, "FI", "FIN", 246L, "ФИНЛЯНДСКАЯ РЕСПУБЛИКА", "ФИНЛЯНДИЯ" },
                    { 220L, "FK", "FLK", 238L, "ФОЛКЛЕНДСКИЕ ОСТРОВА (МАЛЬВИНСКИЕ)", "ФОЛКЛЕНДСКИЕ О-ВА" },
                    { 221L, "TF", "ATF", 260L, "ФРАНЦУЗСКИЕ ЮЖНЫЕ ТЕРРИТОРИИ (ФР.)", "ФР. ЮЖНЫЕ ТЕРРИТОРИИ" },
                    { 222L, "FR", "FRA", 250L, "ФРАНЦУЗСКАЯ РЕСПУБЛИКА", "ФРАНЦИЯ" },
                    { 223L, "PF", "PYF", 258L, "ФРАНЦУЗСКАЯ ПОЛИНЕЗИЯ (ФР.)", "ФРАНЦУЗСКАЯ ПОЛИНЕЗИЯ" },
                    { 224L, "HM", "HMD", 334L, "ОСТРОВ ХЕРД И ОСТРОВА МАКДОНАЛЬД", "ХЕРД И МАКДОНАЛЬД" },
                    { 225L, "HR", "HRV", 191L, "РЕСПУБЛИКА ХОРВАТИЯ", "ХОРВАТИЯ" },
                    { 226L, "CF", "CAF", 140L, "ЦЕНТРАЛЬНО-АФРИКАНСКАЯ РЕСПУБЛИКА (ЦАР)", "ЦЕНТР. - АФР. РЕСПУБЛИКА" },
                    { 227L, "TD", "TCD", 148L, "РЕСПУБЛИКА ЧАД", "ЧАД" },
                    { 228L, "ME", "MNE", 499L, "РЕСПУБЛИКА ЧЕРНОГОРИЯ", "ЧЕРНОГОРИЯ" },
                    { 229L, "CZ", "CZE", 203L, "ЧЕШСКАЯ РЕСПУБЛИКА", "ЧЕХИЯ" },
                    { 230L, "CL", "CHL", 152L, "РЕСПУБЛИКА ЧИЛИ", "ЧИЛИ" },
                    { 231L, "CH", "CHE", 756L, "ШВЕЙЦАРСКАЯ КОНФЕДЕРАЦИЯ", "ШВЕЙЦАРИЯ" },
                    { 232L, "SE", "SWE", 752L, "КОРОЛЕВСТВО ШВЕЦИЯ", "ШВЕЦИЯ" },
                    { 233L, "SJ", "SJM", 744L, "ШПИЦБЕРГЕН И ЯН-МАЙЕН (НОРВ.)", "ШПИЦБЕРГЕН И ЯН-МАЙЕН" },
                    { 234L, "LK", "LKA", 144L, "ДЕМОКРАТИЧЕСКАЯ СОЦИАЛИСТИЧЕСКАЯ РЕСПУБЛИКА ШРИ-ЛАНКА", "ШРИ-ЛАНКА" },
                    { 235L, "EC", "ECU", 218L, "РЕСПУБЛИКА ЭКВАДОР", "ЭКВАДОР" },
                    { 236L, "GQ", "GNQ", 226L, "РЕСПУБЛИКА ЭКВАТОРИАЛЬНАЯ ГВИНЕЯ", "ЭКВАТОРИАЛЬНАЯ ГВИНЕЯ" },
                    { 237L, "AX", "ALA", 248L, "ЭЛАНДСКИЕ ОСТРОВА", "ЭЛАНДСКИЕ ОСТРОВА" },
                    { 238L, "SV", "SLV", 222L, "РЕСПУБЛИКА ЭЛ-САЛЬВАДОР", "ЭЛЬ-САЛЬВАДОР" },
                    { 239L, "ER", "ERI", 232L, "ЭРИТРЕЯ", "ЭРИТРЕЯ" },
                    { 240L, "EE", "EST", 233L, "ЭСТОНСКАЯ РЕСПУБЛИКА", "ЭСТОНИЯ" },
                    { 241L, "ET", "ETH", 231L, "ФЕДЕРАТИВНАЯ ДЕМОКРАТИЧЕСКАЯ  РЕСПУБЛИКА ЭФИОПИЯ", "ЭФИОПИЯ" },
                    { 242L, "ZA", "ZAF", 710L, "ЮЖНО-АФРИКАНСКАЯ РЕСПУБЛИКА", "ЮЖНАЯ АФРИКА" },
                    { 243L, "GS", "SGS", 239L, "ЮЖНАЯ ДЖОРДЖИЯ И ЮЖНЫЕ САНДВИЧЕВЫ ОСТРОВА", "ЮЖНАЯ ДЖОРДЖИЯ И ЮЖНЫЕ САНДВИЧЕВЫ ОСТРОВА" },
                    { 244L, "JM", "JAM", 388L, "ЯМАЙКА", "ЯМАЙКА" },
                    { 245L, "JP", "JPN", 392L, "ЯПОНИЯ", "ЯПОНИЯ" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Code", "ImageId", "Name" },
                values: new object[,]
                {
                    { 1L, "windows", null, "Windows" },
                    { 2L, "apple", null, "Apple" },
                    { 3L, "PS4", null, "PlayStation4" },
                    { 4L, "PS5", null, "PlayStation5" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CountryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1L, 4L, "Компания", "Ubisoft" },
                    { 2L, 4L, "Крутаая компания", "Valve" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
