// using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace ti4Scorepad
{

    public struct PublicObjectiveStruct
    {
        // name, phase, description, points
        public string Name;
        public string Phase;
        public string Description;
        public string Points;
        public int Index;

        public PublicObjectiveStruct(string name, string phase, string description, string points, int index)
        {
            Name = name;
            Phase = phase;
            Description = description;
            Points = points;
            Index = index;
        }
    }

    public static class ClassGlobalVariables
    {

        static List<int> racesInPlay = new List<int>();
        static List<int> publicObjectivesInPlay = new List<int>();
        
        public static void addRaceInPlay(int index) {
            racesInPlay.Add(index);
        }
        public static void addPublicObjectiveInPlay(int index)
        {
            publicObjectivesInPlay.Add(index);
        }
        public static void removePublicObjectiveInPlay(int index)
        {
            publicObjectivesInPlay.Remove(index);
        }
        public static List<int> getPublicObjectivesInPlay()
        {
            return publicObjectivesInPlay;
        }
        public static List<int> getRacesInPlay() {
            return racesInPlay;
        }

        public static Dictionary<int, string> listRaces() {
            return new Dictionary<int, string>() {
                {0, "The Arborec"},
                {1, "The Argent Flight"},
                {2, "The Barony of Letnev"},
                {3, "The Clan of Saar"},
                {4, "The Embers of Muaat"},
                {5, "The Emirates of Hacan"},
                {6, "The Empyrean"},
                {7, "The Federation of Sol"},
                {8, "The Ghosts of Creuss"},
                {9, "The L1Z1X Mindnet"},
                {10, "The Mahact Gene-Sorcerers"},
                {11, "The Mentak Coalition"},
                {12, "The Naalu Collective"},
                {13, "The Naaz-Rokha Alliance"},
                {14, "The Nekro Virus"},
                {15, "The Nomad"},
                {16, "Sardakk N’orr"},
                {17, "The Titans of Ul"},
                {18, "The Universities of Jol-Nar"},
                {19, "The Vuil'Raith Cabal"},
                {20, "The Winnu"},
                {21, "The Xxcha Kingdom"},
                {22, "The Yin Brotherhood"},
                {23, "The Yssaril Tribes"}
            };
        }
        public static PublicObjectiveStruct[] listPublicObjectives()
        {
            // name, phase, description, points, index
            return new PublicObjectiveStruct[] {
                // 1 pointers
                new PublicObjectiveStruct("POPULATE THE OUTER RIM", "STATUS PHASE", "Have units in 3 systems on the edge of the game board other than your home system", "1", 0),
                new PublicObjectiveStruct("ENGINEER A MARVEL", "STATUS PHASE", "Have your flagship or a war sun on the game board", "1", 1),
                new PublicObjectiveStruct("BUILD DEFENCES", "STATUS PHASE", "Have 4 or more structures", "1", 2),
                new PublicObjectiveStruct("EXPLORE DEEP SPACE", "STATUS PHASE", "Have units in 3 systems that do not contain planets", "1", 3),
                new PublicObjectiveStruct("EXPAND BORDERS", "STATUS PHASE", "Control 6 planets in non-home systems", "1", 4),
                new PublicObjectiveStruct("INTIMIDATE COUNCIL", "STATUS PHASE", "Have 1 or more ships in 2 systems that are adjacent to Mecatol Rex's system", "1", 5),
                new PublicObjectiveStruct("FOUND RESEARCH OUTPOSTS", "STATUS PHASE", "Control 3 planets that have technology specialties", "1", 6),
                new PublicObjectiveStruct("CORNER THE MARKET", "STATUS PHASE", "Control 4 planets that eachhave same planet trait", "1", 7),
                new PublicObjectiveStruct("SWAY THE COUNCIL", "STATUS PHASE", "Spend 8 influence", "1", 8),
                new PublicObjectiveStruct("PUSH BOUNDARIES", "STATUS PHASE", "Control more planets than each of 2 of your neighbors", "1", 9),
                new PublicObjectiveStruct("MAKE HISTORY", "STATUS PHASE", "Have units in 2 systems that contain legendary planets, Mecatol Rex or anomalies", "1", 10),
                new PublicObjectiveStruct("LEAD FROM THE FRONT", "STATUS PHASE", "Spend a total of 3 tokens frmo your tactic and/or strategy pools", "1", 11),
                new PublicObjectiveStruct("DEVELOP WEAPONRY", "STATUS PHASE", "Own 2 unit upgrade technologies", "1", 12),
                new PublicObjectiveStruct("NEGOTIATE TRADE ROUTES", "STATUS PHASE", "Spend 5 trade goods", "1", 13),
                new PublicObjectiveStruct("DIVERSIFY RESEARCH", "STATUS PHASE", "Own 2 technologies in eachof 2 colors", "1", 14),
                new PublicObjectiveStruct("DISCOVER LOST OUTPOSTS", "STATUS PHASE", "Control 2 planets that have attachments", "1", 15),
                new PublicObjectiveStruct("RAISE A FLEET", "STATUS PHASE", "Have 5 or more non-fighter ships in 1 system", "1", 16),
                new PublicObjectiveStruct("AMASS WEALTH", "STATUS PHASE", "Spend 3 influence, 3 resources, and 3 trade goods", "1", 17),
                new PublicObjectiveStruct("IMPROVE INFRASTRUCTURE", "STATUS PHASE", "Have structures on 3 planets outside of your home system", "1", 18),
                new PublicObjectiveStruct("ERECT A MONUMENT", "STATUS PHASE", "Spend 8 resources", "1", 19),
                // 2 pointers
                new PublicObjectiveStruct("CONSTRUCT MASSIVE CITIES", "STATUS PHASE", "Have 7 or more structures", "2", 20),
                new PublicObjectiveStruct("MASTER THE SCIENCES", "STATUS PHASE", "Own 2 technologies in each of 4 colors", "2", 21),
                new PublicObjectiveStruct("SUBDUE THE GALAXY", "STATUS PHASE", "Control 11 planets in non-home systems", "2", 22),
                new PublicObjectiveStruct("GALVANIZE THE PEOPLE", "STATUS PHASE", "Spend a total of 6 tokens from your tactic and/or strategy pools", "2", 23),
                new PublicObjectiveStruct("UNIFY THE COLONIES", "STATUS PHASE", "Control 6 planets that each have the same planet trait", "2", 24),
                new PublicObjectiveStruct("CENTRALIZE GALACTIC TRADE", "STATUS PHASE", "Spend 10 trade goods", "2", 25),
                new PublicObjectiveStruct("ACHIEVE SUPREMACY", "STATUS PHASE", "Have your flagship or a war sun in another player's home system or the Mecatol Rex system", "2", 26),
                new PublicObjectiveStruct("FOUND A GOLDEN AGE", "STATUS PHASE", "Spend 16 resources", "2", 27),
                new PublicObjectiveStruct("FORM GALACTIC BRAIN TRUST", "STATUS PHASE", "Control 5 planets that have technology specialties", "2", 28),
                new PublicObjectiveStruct("MANIPULATE GALACTIC LAW", "STATUS PHASE", "Spend 16 influence", "2", 29),
                new PublicObjectiveStruct("RECLAIM ANCIENT MONUMENTS", "STATUS PHASE", "Control 3 planets that have attachments", "2", 30),
                new PublicObjectiveStruct("HOLD VAST RESERVES", "STATUS PHASE", "Spend 6 influence, 6 resources, and 6 trade goods", "2", 31),
                new PublicObjectiveStruct("CONTROL THE BORDERLANDS", "STATUS PHASE", "Have units in 5 systems on the edge of the game board other than your home system", "2", 32),
                new PublicObjectiveStruct("PROTECT THE BORDER", "STATUS PHASE", "Have structures on 5 planets outside of your home system", "2", 33),
                new PublicObjectiveStruct("PATROL VAST TERRITORIES", "STATUS PHASE", "Have units in 5 systems that do not contain planets", "2", 34),
                new PublicObjectiveStruct("BECOME A LEGEND", "STATUS PHASE", "Have units in 4 systems that contain legendary planets, Mecatol Rex or anomalies", "2", 35),
                new PublicObjectiveStruct("CONQUER THE WEAK", "STATUS PHASE", "Control 1 planet that is in another player's home system", "2", 36),
                new PublicObjectiveStruct("REVOLUTIONIZE WARFARE", "STATUS PHASE", "Own 3 unit upgrade technologies", "2", 37),
                new PublicObjectiveStruct("RULE DISTANT LANDS", "STATUS PHASE", "Control 2 planets that are each in or adjacent to a different, other player's home system", "2", 38),
                new PublicObjectiveStruct("COMMAND AN ARMADA", "STATUS PHASE", "Have 8 or more non-fighter ships in 1 system", "2", 39)
            };
        }

        public static int[,] staticPublicObjectivesData() {
            // returns:
            // left, top, points
            return new int[,]{
                {10, 250, 1},
                {310, 250, 1},
                {610, 250, 1},
                {910, 250, 1},
                {1210, 250, 1},
                {10, 520, 2},
                {310, 520, 2},
                {610, 520, 2},
                {910, 520, 2},
                {1210, 520, 2}
            };
        }

        public static int[,] positionsStaticRaces()
        {
            return new int[,]{
                {10, 10},
                {10, 60},
                {10, 110},
                {10, 160},
                {300, 10},
                {300, 60},
                {300, 110},
                {300, 160}
            };
        }
    }
}
