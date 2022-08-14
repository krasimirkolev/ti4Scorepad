using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti4Scorepad
{
    public struct PublicObjective
    {
        // name, phase, description, points
        public string Name;
        public string Phase;
        public string Description;
        public string Points;
        public int Index;

        public PublicObjective(string name, string phase, string description, string points, int index) {
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
        public static PublicObjective[] listPublicObjectives()
        {
            // name, phase, description, points
            return new PublicObjective[] {
                // 1 pointers
                new PublicObjective("POPULATE THE OUTER RIM", "STATUS PHASE", "Have unist in 3 systems on the edge of the game board other than your home system", "1", 0),
                new PublicObjective("ENGINEER A MARVEL", "STATUS PHASE", "Have your flagship or a war sun on the game board", "1", 1),
                new PublicObjective("BUILD DEFENCES", "STATUS PHASE", "Have 4 or more structures", "1", 2),
                new PublicObjective("EXPLORE DEEP SPACE", "STATUS PHASE", "Have unist in 3 systems that do not contain planets", "1", 3),
                new PublicObjective("EXPAND BORDERS", "STATUS PHASE", "Control 6 planets in non-home systems", "1", 4),
                new PublicObjective("INTIMIDATE COUNCIL", "STATUS PHASE", "Have 1 or more ships in 2 systems that are adjacentto MecatolRex's system", "1", 5),
                new PublicObjective("FOUND RESEARCH OUTPOSTS", "STATUS PHASE", "Control 3 planets that have technology specialties", "1", 6),
                new PublicObjective("CORNER THE MARKET", "STATUS PHASE", "Control 4 planets that eachhave same planet trait", "1", 7),
                new PublicObjective("SWAY THE COUNCIL", "STATUS PHASE", "Spend 8 influence", "1", 8),
                new PublicObjective("PUSH BOUNDARIES", "STATUS PHASE", "Control more planets than each of 2 of your neighbors", "1", 9),
                new PublicObjective("MAKE HISTORY", "STATUS PHASE", "Have units in 2 systems that contain legendary planets, Mecatol Rex or anomalies", "1", 10),
                new PublicObjective("LEAD FROM THE FRONT", "STATUS PHASE", "Spend a total of 3 tokens frmo your tactic and/or strategy pools", "1", 11),
                new PublicObjective("DEVELOP WEAPONRY", "STATUS PHASE", "Own 2 unit upgrade technologies", "1", 12),
                new PublicObjective("NEGOTIATE TRADE ROUTES", "STATUS PHASE", "Spend 5 trade goods", "1", 13),
                new PublicObjective("DIVERSIFY RESEARCH", "STATUS PHASE", "Own 2 technologies in eachof 2 colors", "1", 14),
                new PublicObjective("DISCOVER LOST OUTPOSTS", "STATUS PHASE", "Control 2 planets that have attachments", "1", 15),
                new PublicObjective("RAISE A FLEET", "STATUS PHASE", "Have 5 or more non-fighter ships in 1 system", "1", 16),
                new PublicObjective("AMASS WEALTH", "STATUS PHASE", "Spend 3 influence, 3 resources, and 3 trade goods", "1", 17),
                new PublicObjective("IMPROVE INFRASTRUCTURE", "STATUS PHASE", "Have structures on 3 planets outside of your home system", "1", 18),
                new PublicObjective("ERECT A MONUMENTS", "STATUS PHASE", "Spend 8 resources", "1", 19),
                // 2 pointers
                new PublicObjective("CONSTRUCT MASSIVE CITIES", "STATUS PHASE", "Have 7 or more structures", "2", 20),
                new PublicObjective("MASTER THE SCIENCES", "STATUS PHASE", "Own 2 technologies in each of 4 colors", "2", 21),
                new PublicObjective("SUBDUE THE GALAXY", "STATUS PHASE", "Control 11 planets in non-home systems", "2", 22),
                new PublicObjective("GALVANIZE THE PEOPLE", "STATUS PHASE", "Spend a total of 6 tokens from your tactic and/or strategy pools", "2", 23),
                new PublicObjective("UNIFY THE COLONIES", "STATUS PHASE", "Control 6 planets that each have the same planet trait", "2", 24),
                new PublicObjective("CENTRALIZE GALACTIC TRADE", "STATUS PHASE", "Spend 10 trade goods", "2", 25),
                new PublicObjective("ACHIEVE SUPREMACY", "STATUS PHASE", "Have your flagship or a war sun in another player's home system or the Mecatol Rex system", "2", 26),
                new PublicObjective("FOUND A GOLDEN AGE", "STATUS PHASE", "Spend 16 resources", "2", 27),
                new PublicObjective("FORM GALACTIC BRAIN TRUST", "STATUS PHASE", "Control 5 planets that have technology specialties", "2", 28),
                new PublicObjective("MANIPULATE GALACTIC LAW", "STATUS PHASE", "Spend 16 influence", "2", 29),
                new PublicObjective("RECLAIM ANCIENT MONUMENTS", "STATUS PHASE", "Control 3 planets that have attachments", "2", 30),
                new PublicObjective("HOLD VAST RESERVES", "STATUS PHASE", "Spend 6 influence, 6 resources, and 6 trade goods", "2", 31),
                new PublicObjective("CONTROL THE BORDERLANDS", "STATUS PHASE", "Have units in 5 systems on the edge of the game board other than your home system", "2", 32),
                new PublicObjective("PROTECT THE BORDER", "STATUS PHASE", "Have structures on 5 planets outside of your home system", "2", 33),
                new PublicObjective("PATROL VAST TERRITORIES", "STATUS PHASE", "Have units in 5 systems that do not contain planets", "2", 34),
                new PublicObjective("BECOME A LEGEND", "STATUS PHASE", "Have units in 4 systems that contain legendary planets, Mecatol Rex or anomalies", "2", 35),
                new PublicObjective("CONQUER THE WEAK", "STATUS PHASE", "Control 1 planet that is in another player's home system", "2", 36),
                new PublicObjective("REVOLUTIONIZE WARFARE", "STATUS PHASE", "Own 3 unit upgrade technologies", "2", 37),
                new PublicObjective("RULE DISTANT LANDS", "STATUS PHASE", "Control 2 planets that are each in or adjacent to a different, other player's home system", "2", 38),
                new PublicObjective("COMMAND AN ARMADA", "STATUS PHASE", "Have 8 or more non-fighter ships in 1 system", "2", 39)
            };
        }

        public static List<ti4Scorepad.publicObjective> emptyPublicObjectives() {
            return new List<ti4Scorepad.publicObjective>()
            {
                new ti4Scorepad.publicObjective(0),
                new ti4Scorepad.publicObjective(1),
                new ti4Scorepad.publicObjective(2),
                new ti4Scorepad.publicObjective(3),
                new ti4Scorepad.publicObjective(4),
                new ti4Scorepad.publicObjective(5),
                new ti4Scorepad.publicObjective(6),
                new ti4Scorepad.publicObjective(7),
                new ti4Scorepad.publicObjective(8),
                new ti4Scorepad.publicObjective(9)
            };
        }

        public static int[,] positionsStaticPublicObjectives() {
            return new int[,]{
                {10, 250},
                {170, 250},
                {330, 250},
                {490, 250},
                {650, 250},
                {10, 520},
                {170, 520},
                {330, 520},
                {490, 520},
                {650, 520}
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
