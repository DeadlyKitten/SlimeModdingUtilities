using System.Collections.Generic;

namespace SMU.Constants
{
    /// <summary>
    /// Utility class for working with stage IDs and names.
    /// </summary>
    public static class Stages
    {
        /// <summary>
        /// Try to get stage ID from the character's name.
        /// </summary>
        /// <param name="name">Name of the stage</param>
        /// <param name="id">ID of the stage, if found.</param>
        /// <returns>Whether or not the ID was found for the given name.</returns>
        public static bool TryGetIdFromName(string name, out string id) => nameToId.TryGetValue(name, out id);

        /// <summary>
        /// Get stage ID from the character's name.
        /// </summary>
        /// <param name="name">Name of the stage.</param>
        /// <returns>ID of the stage with the given name, or null if not found.</returns>
        public static string GetIdFromName(string name)
        {
            if (TryGetIdFromName(name, out var id))
                return id;
            return null;
        }

        /// <summary>
        /// Try to get stage name from the stage's ID.
        /// </summary>
        /// <param name="id">ID of the stage</param>
        /// <param name="name">Name of the stage, if found.</param>
        /// <returns>Whether or not the name was found for the given ID.</returns>
        public static bool TryGetNameFromId(string id, out string name) => idToName.TryGetValue(id, out name);

        /// <summary>
        /// Get stage name from the stage's ID.
        /// </summary>
        /// <param name="id">ID of the stage.</param>
        /// <returns>Name of the stage with the given ID, or null if not found.</returns>
        public static string GetNameFromId(string id)
        {
            if (TryGetNameFromId(id, out var name))
                return name;
            return null;
        }

        /// <summary>
        /// Get a list of all stage IDs.
        /// </summary>
        /// <returns>The list of IDs.</returns>
        public static List<string> GetStageIds() => new List<string>(stageIds);

        private static readonly Dictionary<string, string> nameToId = new Dictionary<string, string>
        {
            { "CatDogs House", "House" },
            { "CatDog's House", "House" },
            { "Ghost Zone", "Zone" },
            { "Glove World", "CarnivalLofi" },
            { "Harmonic Convergence", "SpiritWorld" },
            { "Irken Armada Invasion", "Armada" },
            { "Jellyfish Fields", "SlideHouse" },
            { "Omashu", "Omashu" },
            { "Powdered Toast Trouble", "DuoKitchen" },
            { "Rooftop Rumble", "Rooftop" },
            { "Royal Woods Cemetery", "YMC" },
            { "Sewers Slam", "SewersCombined" },
            { "Showdown at Teeter Totter Gulch", "Playground" },
            { "Space Madness", "DuoMadness" },
            { "Technodrome Takedown", "Drome" },
            { "The Dump", "Trash" },
            { "The Flying Dutchman's Ship", "Shanty" },
            { "The Flying Dutchmans Ship", "Shanty" },
            { "The Loud House", "Loud" },
            { "Traffic Jam", "Stomp" },
            { "Western Air Temple", "Temple2" },
            { "Wild Waterfall", "Waterfall" }
        };

        private static readonly Dictionary<string, string> idToName = new Dictionary<string, string>
        {
            { "House", "CatDog's House" },
            { "Zone", "Ghost Zone" },
            { "CarnivalLofi", "Glove World" },
            { "SpiritWorld", "Harmonic Convergence" },
            { "Armada", "Irken Armada Invasion" },
            { "SlideHouse", "Jellyfish Fields" },
            { "Omashu", "Omashu" },
            { "DuoKitchen", "Powdered Toast Trouble" },
            { "Rooftop", "Rooftop Rumble" },
            { "YMC", "Royal Woods Cemetery" },
            { "SewersCombined", "Sewers Slam" },
            { "Playground", "Showdown at Teeter Totter Gulch" },
            { "DuoMadness", "Space Madness" },
            { "Drome", "Technodrome Takedown" },
            { "Trash", "The Dump" },
            { "Shanty", "The Flying Dutchman's Ship" },
            { "Loud", "The Loud House" },
            { "Stomp", "Traffic Jam" },
            { "Temple2", "Western Air Temple" },
            { "Waterfall", "Wild Waterfall" }
        };

        private static readonly string[] stageIds =
        {
            "House",
            "Zone",
            "CarnivalLofi",
            "SpiritWorld",
            "Armada",
            "SlideHouse",
            "Omashu",
            "DuoKitchen",
            "Rooftop",
            "YMC",
            "SewersCombined",
            "Playground",
            "DuoMadness",
            "Drome",
            "Trash",
            "Shanty",
            "Loud",
            "Stomp",
            "Temple2",
            "Waterfall"
        };
    }
}
