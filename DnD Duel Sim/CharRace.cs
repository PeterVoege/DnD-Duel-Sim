using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    public enum Race
    {
        HillDwarf,
        MountainDwarf,
        HighElf,
        WoodElf,
        DarkElf,
        LightfootHalfling,
        StoutHalfling,
        Human,
        Dragonborn,
        ForestGnome,
        RockGnome,
        HalfElf,
        HalfOrc,
        Tiefling
    }
    public static class CharRace
    {
        public static int GetRacialSpeed(Race race)
        {
            switch (race)
            {
                case Race.HillDwarf:
                    return 25;
                case Race.MountainDwarf:
                    return 25;
                case Race.HighElf:
                    return 30;
                case Race.WoodElf:
                    return 35;
                case Race.DarkElf:
                    return 30;
                case Race.LightfootHalfling:
                    return 25;
                case Race.StoutHalfling:
                    return 25;
                case Race.Human:
                    return 30;
                case Race.Dragonborn:
                    return 30;
                case Race.ForestGnome:
                    return 25;
                case Race.RockGnome:
                    return 25;
                case Race.HalfElf:
                    return 30;
                case Race.HalfOrc:
                    return 30;
                case Race.Tiefling:
                    return 30;
                default:
                    return 30;
            }
        }

        // Short name, long name.
        public static Tuple<string, string> GetRandomName(Race race, ref DiceRoller rng)
        {
            // Dwarf names
            string[] dwarfMaleNames = new string[] { "Adrik", "Alberich", "Baern", "Barendd", "Brottor", "Bruenor", "Dain", "Darrak", "Delg", "Eberk", "Einkil", "Fargrim", "Flint", "Gardain", "Harbek", "Kildrak", "Morgran", "Orsik", "Oskar", "Rangrim", "Rurik", "Taklinn", "Thoradin", "Thorin", "Tordek", "Traubon", "Travok", "Ulfgar", "Veit", "Vondal" };
            string[] dwarfFemaleNames = new string[] { "Amber", "Artin", "Audhild", "Bardryn", "Dagnal", "Diesa", "Eldeth", "Falkrunn", "Finellen", "Gunnloda", "Gurdis", "Helja", "Hlin", "Kathra", "Kristryd", "Ilde", "Liftrasa", "Mardred", "Riswynn", "Sannl", "Torbera", "Torgga", "Vistra" };
            string[][] dwarfFirstNames = new string[][] { dwarfMaleNames, dwarfFemaleNames };

            string[] dwarfLastNames = new string[] { "Balderk", "Battlehammer", "Brawnanvil", "Dankil", "Fireforge", "Frostbeard", "Gorunn", "Holderhek", "Ironfist", "Loderr", "Lutgehr", "Rumnaheim", "Strakeln", "Torunn", "Ungart" };

            // Elf names
            string[] elfMaleNames = new string[] { "Adran", "Aelar", "Aramil", "Arannis", "Aust", "Beiro", "Berrian", "Carrie", "Enialis", "Erdan", "Erevan", "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios", "Laucian", "Mindartis", "Paelias", "Peren", "Quarion", "Riardon", "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis" };
            string[] elfFemaleNames = new string[] { "Adrie", "Althaea", "Anastrianna", "Andraste", "Antinua", "Bethrynna", "Birel", "Caelynn", "Drusilia", "Enna", "Felosial", "Ielenia", "Jelenneth", "Keyleth", "Leshanna", "Lia", "Meriele", "Mialee", "Naivara", "Quelenna", "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui", "Theirastra", "Thia", "Vadania", "Valanthe", "Xanaphia" };
            // Child names, unused:
            string[] elfChildNames = new string[] { "Ara", "Bryn", "Del", "Eryn", "Faen", "Innil", "Lael", "Mella", "Naill", "Naeris", "Phann", "Rael", "Rinn", "Sai", "Syllin", "Thia", "Vall" };
            string[] elfLastNames = new string[] { "Amakiir", "Amastacia", "Galanodel", "Holimion", "Ilphelkiir", "Liadon", "Meliamne", "Naïlo", "Siannodel", "Xiloscient" };

            string[][] elfFirstNames = new string[][] { elfMaleNames, elfFemaleNames };

            // Halfling names
            string[] halflingMaleNames = new string[] { "Alton", "Ander", "Cade", "Corrin", "Eldon", "Errich", "Finnan", "Garret", "Lindal", "Lyle", "Merric", "Milo", "Osborn", "Perrin", "Reed", "Roscoe", "Wellby" };
            string[] halflingFemaleNames = new string[] { "Andry", "Bree", "Callie", "Cora", "Euphemia", "Jillian", "Kithri", "Lavinia", "Lidda", "Merla", "Nedda", "Paela", "Portia", "Seraphina", "Shaena", "Trym", "Vani", "Verna" };
            string[] halflingLastNames = new string[] { "Brushgather", "Goodbarrel", "Greenbottle", "High-hill", "Hilltopple", "Leagallow", "Tealeaf", "Thorngage", "Tosscobble", "Underbough" };

            string[][] halflingFirstNames = new string[][] { halflingMaleNames, halflingFemaleNames };

            // Human names
            string[] CalishiteMaleNames = new string[] { "Aseir", "Bardeid", "Haseid", "Khemed", "Mehmen", "Sudeiman", "Zasheir" };
            string[] CalishiteFemaleNames = new string[] { "Atala", "Ceidil", "Hama", "Jasmal", "Meilil", "Seipora", "Yasheira", "Zasheida" };
            string[] CalishiteLastNames = new string[] { "Basha", "Dumein", "Jassan", "Khalid", "Mostana", "Pashar", "Rein" };
            string[] ChondathanMaleNames = new string[] { "Darvin", "Dorn", "Evendur", "Gorstag", "Grim", "Helm", "Malark", "Morn", "Randal", "Stedd" };
            string[] ChondathanFemaleNames = new string[] { "Arveene", "Esvele", "jhessail", "Kerri", "Lureene", "Miri", "Rowan", "Shandri", "Tessele" };
            string[] ChondathanLastNames = new string[] { "Amblecrown", "Buckman", "Dundragon", "Evenwood", "Greycastle", "Tallstag" };
            string[] DamaranMaleNames = new string[] { "Bar", "Fodel", "Glar", "Grigor", "Igan", "Ivor", "Kosef", "Mival", "Orel", "Pavel", "Sergor" };
            string[] DamaranFemaleNames = new string[] { "Alethra", "Kara", "Katernin", "Mara", "Natali", "Olma", "Tana", "Zora" };
            string[] DamaranLastNames = new string[] { "Bersk", "Chernin", "Dotsk", "Kulenov", "Marsk", "Nemetsk", "Shemov", "Starag" };
            string[] IlluskanMaleNames = new string[] { "Ander", "Blath", "Bran", "Frath", "Geth", "Lander", "Luth", "Malcer", "Stor", "Taman", "Urth" };
            string[] IlluskanFemaleNames = new string[] { "Amafrey", "Betha", "Cefrey", "Kethra", "Mara", "Olga", "Silifrey", "Westra" };
            string[] IlluskanLastNames = new string[] { "Brightwood, Helder, Hornraven, Lackman, Stormwind, Windrivver" };
            string[] MulanMaleNames = new string[] { "Aoth", "Bareris", "Ehput-Ki", "Kethoth", "Mumed", "Ramas", "So-Kehur", "Thazar-De", "Urhur" };
            string[] MulanFemaleNames = new string[] { "Arizima", "Chathi", "Nephis", "Nulara", "Murithi", "Sefris", "Thola", "Umara", "Zolis" };
            string[] MulanLastNames = new string[] { "Ankhalab", "Anskuld", "Fezim", "Hahpet", "Nathandem", "Sepret", "Uuthrakt" };
            string[] RashemiMaleNames = new string[] { "Borivik", "Faurgar", "Jandar", "Kanithar", "Madislak", "Ralmevik", "Shaumar", "Vladislak" };
            string[] RashemiFemaleNames = new string[] { "Fyevarra", "Hulmarra", "Immith", "Imzel", "Navarra", "Shevarra", "Tammith", "Yuldra" };
            string[] RashemiLastNames = new string[] { "Chergoba", "Dyernina", "Iltazyara", "Murnyethara", "Stayanoga", "Ulmokina" };
            string[] ShouMaleNames = new string[] { "An", "Chen", "Chi", "Fai", "Jiang", "Jun", "Lian", "Long", "Meng", "On", "Shan", "Shui", "Wen" };
            string[] ShouFemaleNames = new string[] { "Bai", "Chao", "Jia", "Lei", "Mei", "Qiao", "Shui", "Tai" };
            string[] ShouLastNames = new string[] { "Chien", "Huang", "Kao", "Kung", "Lao", "Ling", "Mei", "Pin", "Shin", "Sum", "Tan", "Wan" };
            string[] TuramiMaleNames = new string[] { "Anton", "Diero", "Marcon", "Pieron", "Rimardo", "Romero", "Salazar", "Umbero" };
            string[] TuramiFemaleNames = new string[] { "Balama", "Dona", "Faila", "Jalana", "Luisa", "Marta", "Quara", "Selise", "Vonda" };
            string[] TuramiLastNames = new string[] { "Agosto", "Astorio", "Calabra", "Domine", "Falone", "Marivaldi", "Pisacar", "Ramondo" };
            // Tethyrians have no unique names.

            string[][] humanMaleNames = new string[][] { CalishiteMaleNames, ChondathanMaleNames, DamaranMaleNames, IlluskanMaleNames, MulanMaleNames, RashemiMaleNames, ShouMaleNames, TuramiMaleNames };
            string[][] humanFemaleNames = new string[][] { CalishiteFemaleNames, ChondathanFemaleNames, DamaranFemaleNames, IlluskanFemaleNames, MulanFemaleNames, RashemiFemaleNames, ShouFemaleNames, TuramiFemaleNames };

            string[][][] humanFirstNames = new string[][][] { humanMaleNames, humanFemaleNames };

            string[][] humanLastNames = new string[][] { CalishiteLastNames, ChondathanLastNames, DamaranLastNames, IlluskanLastNames, MulanLastNames, RashemiLastNames, ShouLastNames, TuramiLastNames };

            // Dragonborn names
            string[] dragonbornMaleNames = new string[] { "Arjhan", "Balasar", "Bharash", "Donaar", "Ghesh", "Heskan", "Kriv", "Medrash", "Mehen", "Nadarr", "Pandjed", "Patrin", "Rhogar", "Shamash", "Shedinn", "Tarhun", "Torinn" };
            string[] dragonbornFemaleNames = new string[] { "Akra", "Biri", "Daar", "Farideh", "Harann", "Havilar", "Jheri", "Kava", "Korinn", "Mishann", "Nala", "Perra", "Raiann", "Sora", "Surina", "Thava", "Uadjit" };
            // Child names, unused:
            string[] dragonbornChildNames = new string[] { "Climber", "Earbender", "Leaper", "Pious", "Shieldbiter", "Zealous" };
            string[] dragonbornLastNames = new string[] { "Clethtinthiallor", "Daardendrian", "Delmirev", "Drachedandion", "Fenkenkabradon", "Kepeshkmolik", "Kerrhylon", "Kimbatuul", "Linxakasendalor", "Myastan", "Nemmonis", "Norixius", "Ophinshtalajiir", "Prexijandilin", "Shestendeliath", "Turnuroth", "Verthisathurgiesh", "Yarjerit" };

            string[][] dragonbornFirstNames = new string[][] { dragonbornMaleNames, dragonbornFemaleNames };

            // Gnome names
            string[] gnomeMaleNames = new string[] { "Alston", "Alvyn", "Boddynock", "Brocc", "Burgell", "Dimble", "Eldon", "Erky", "Fonkin", "Frug", "Gerbo", "Gimble", "Glim", "Jebeddo", "Kellen", "Namfoodle", "Orryn", "Roondar", "Seebo", "Sindri", "Warryn", "Wrenn", "Zook" };
            string[] gnomeFemaleNames = new string[] { "Bimpnottin", "Breena", "Caramip", "Carlin", "Donella", "Duvamil", "Ella", "Ellyjobell", "Ellywick", "Lilli", "Loopmottin", "Lorilla", "Mardnab", "Nissa", "Nyx", "Oda", "Orla", "Roywyn", "Shamil", "Tana", "Waywocket", "Zanna" };
            // Nicknames, unused.
            string[] gnomeNicknames = new string[] { "Aleslosh", "Ashhearth", "Badger", "Cloak", "Doublelock", "Filchbatter", "Fnipper", "Ku", "Nim", "Oneshoe", "Pock", "Sparklegem", "Stumbleduck" };
            string[] gnomeLastNames = new string[] { "Beren", "Daergel", "Folkor", "Garrick", "Nackle", "Murnig", "Ningel", "Raulnor", "Scheppen", "Timbers", "Turen" };

            string[][] gnomeFirstNames = new string[][] { gnomeMaleNames, gnomeFemaleNames };

            // Orc names
            string[] orcMaleNames = new string[] { "Dench", "Feng", "Gell", "Henk", "Holg", "Imsh", "Keth", "Krusk", "Mhurren", "Ront", "Shump", "Thokk" };
            string[] orcFemaleNames = new string[] { "Baggi", "Emen", "Engong", "Kansif", "Myev", "Neega", "Ovak", "Ownka", "Shautha", "Sutha", "Vola", "Volen", "Yevelda" };

            string[][] orcFirstNames = new string[][] { orcMaleNames, orcFemaleNames };

            // Tiefling names
            string[] tieflingMaleNames = new string[] { "Akmenos", "Amnon", "Barakas", "Damakos", "Ekemon", "Iados", "Kairon", "Leucis", "Melech", "Mordai", "Morthos", "Pelaios", "Skamos", "Therai" };
            string[] tieflingFemaleNames = new string[] { "Akta", "Anakis", "Bryseis", "Criella", "Damaia", "Ea", "Kallista", "Lerissa", "Makaria", "Nemeia", "Orianna", "Phelaia", "Rieta" };
            string[] tieflingVirtueNames = new string[] { "Art", "Carrion", "Chant", "Creed", "Despair", "Excellence", "Fear", "Glory", "Hope", "Ideal", "Music", "Nowhere", "Open", "Poetry", "Quest", "Random", "Reverence", "Sorrow", "Temerity", "Torment", "Weary" };

            string[][] tieflingNames = new string[][] { tieflingMaleNames, tieflingFemaleNames, tieflingVirtueNames };
            
            switch (race)
            {
                case Race.HillDwarf:
                case Race.MountainDwarf:
                    int gender = rng.CoinFlip() - 1;
                    int index1 = rng.CustomDice(dwarfFirstNames[gender].Length) - 1;
                    int index2 = rng.CustomDice(dwarfLastNames.Length) - 1;
                    string shortName = dwarfFirstNames[gender][index1];
                    string longName = shortName + " " + dwarfLastNames[index2];
                    return Tuple.Create(shortName, longName);

                case Race.HighElf:
                case Race.WoodElf:
                case Race.DarkElf:
                    gender = rng.CoinFlip() - 1;
                    index1 = rng.CustomDice(elfFirstNames[gender].Length) - 1;
                    index2 = rng.CustomDice(elfLastNames.Length) - 1;
                    shortName = elfFirstNames[gender][index1];
                    longName = shortName + " " + elfLastNames[index2];
                    return Tuple.Create(shortName, longName);

                case Race.LightfootHalfling:
                case Race.StoutHalfling:
                    gender = rng.CoinFlip() - 1;
                    index1 = rng.CustomDice(halflingFirstNames[gender].Length) - 1;
                    index2 = rng.CustomDice(halflingLastNames.Length) - 1;
                    shortName = halflingFirstNames[gender][index1];
                    longName = shortName + " " + halflingLastNames[index2];
                    return Tuple.Create(shortName, longName);

                case Race.Human:
                    gender = rng.CoinFlip() - 1;
                    int ethnicity = rng.d8() - 1;
                    index1 = rng.CustomDice(humanFirstNames[gender][ethnicity].Length) - 1;
                    index2 = rng.CustomDice(humanLastNames[ethnicity].Length) - 1;
                    shortName = humanFirstNames[gender][ethnicity][index1];
                    longName = shortName + " " + humanLastNames[ethnicity][index2];
                    // Inverted order for Shou ethnicity
                    if (ethnicity == 6) { longName = humanLastNames[ethnicity][index2] + " " + shortName; }
                    return Tuple.Create(shortName, longName);

                case Race.Dragonborn:
                    gender = rng.CoinFlip() - 1;
                    index1 = rng.CustomDice(dragonbornFirstNames[gender].Length) - 1;
                    index2 = rng.CustomDice(dragonbornLastNames.Length) - 1;
                    shortName = dragonbornFirstNames[gender][index1];
                    longName = shortName + " " + dragonbornLastNames[index2];
                    return Tuple.Create(shortName, longName);

                case Race.ForestGnome:
                case Race.RockGnome:
                    gender = rng.CoinFlip() - 1;
                    index1 = rng.CustomDice(gnomeFirstNames[gender].Length) - 1;
                    index2 = rng.CustomDice(gnomeLastNames.Length) - 1;
                    int index3 = rng.CustomDice(gnomeNicknames.Length) - 1;
                    shortName = gnomeNicknames[index3];
                    longName = gnomeFirstNames[gender][index1] + " \"" + shortName + "\" " + gnomeLastNames[index2];
                    return Tuple.Create(shortName, longName);

                case Race.HalfElf:
                    gender = rng.CoinFlip() - 1;
                    ethnicity = rng.d8() - 1;
                    if (rng.CoinFlip() == 1) // Human first name, elf last name
                    {
                        index1 = rng.CustomDice(humanFirstNames[gender][ethnicity].Length) - 1;
                        index2 = rng.CustomDice(elfLastNames.Length) - 1;
                        shortName = humanFirstNames[gender][ethnicity][index1];
                        longName = shortName + " " + elfLastNames[index2];
                    }
                    else // Elf first name, Human last name.
                    {
                        index1 = rng.CustomDice(elfFirstNames[gender].Length) - 1;
                        index2 = rng.CustomDice(humanLastNames[ethnicity].Length) - 1;
                        shortName = elfFirstNames[gender][index1];
                        longName = shortName + " " + humanLastNames[ethnicity][index2];
                    }
                    return Tuple.Create(shortName, longName);

                case Race.HalfOrc:
                    gender = rng.CoinFlip() - 1;
                    if (rng.CoinFlip() == 1) // Human name
                    {
                        ethnicity = rng.d8() - 1;
                        index1 = rng.CustomDice(humanFirstNames[gender][ethnicity].Length) - 1;
                        index2 = rng.CustomDice(humanLastNames[ethnicity].Length) - 1;
                        shortName = humanFirstNames[gender][ethnicity][index1];
                        longName = shortName + " " + humanLastNames[ethnicity][index2];
                    }
                    else // Orc name (no last name)
                    {
                        index1 = rng.CustomDice(orcFirstNames[gender].Length) - 1;
                        shortName = orcFirstNames[gender][index1];
                        longName = shortName;
                    }
                    
                    return Tuple.Create(shortName, longName);

                case Race.Tiefling:
                    gender = rng.CustomDice(3) - 1; // Virtue names aren't a gender, but eh, close enough.
                    index1 = rng.CustomDice(tieflingNames[gender].Length) - 1;
                    shortName = tieflingNames[gender][index1];
                    return Tuple.Create(shortName, shortName); // No last name for tieflings.

                default:
                    return Tuple.Create("Mystery man", "Mystery man");
            }
        }

        public static string GetString(Race race)
        {
            switch (race)
            {
                case Race.HillDwarf:
                    return "Hill Dwarf";
                case Race.MountainDwarf:
                    return "Mountain Dwarf";
                case Race.HighElf:
                    return "High Elf";
                case Race.WoodElf:
                    return "Wood Elf";
                case Race.DarkElf:
                    return "Dark Elf";
                case Race.LightfootHalfling:
                    return "Lightfoot Halfling";
                case Race.StoutHalfling:
                    return "Stout Halfling";
                case Race.Human:
                    return "Human";
                case Race.Dragonborn:
                    return "Dragonborn";
                case Race.ForestGnome:
                    return "Forest Gnome";
                case Race.RockGnome:
                    return "Rock Gnome";
                case Race.HalfElf:
                    return "Half-Elf";
                case Race.HalfOrc:
                    return "Half-Orc";
                case Race.Tiefling:
                    return "Tiefling";
                default:
                    return "Unknown";
            }
        }
    }
}
