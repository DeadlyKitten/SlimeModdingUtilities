using System.Collections.Generic;

namespace SMU.Constants
{
    /// <summary>
    /// Utility class for working with character IDs and names.
    /// </summary>
    public static class Characters
    {
        /// <summary>
        /// Try to get character ID from the character's name.
        /// </summary>
        /// <param name="name">Name of the character</param>
        /// <param name="id">ID of the character, if found.</param>
        /// <returns>Whether or not the ID was found for the given name.</returns>
        public static bool TryGetIdFromName(string name, out string id) => nameToId.TryGetValue(name, out id);

        /// <summary>
        /// Get character ID from the character's name.
        /// </summary>
        /// <param name="name">Name of the character.</param>
        /// <returns>ID of the character with the given name, or null if not found.</returns>
        public static string GetIdFromName(string name)
        {
            if (TryGetIdFromName(name, out var id))
                return id;
            return null;
        }

        /// <summary>
        /// Try to get character name from the character's ID.
        /// </summary>
        /// <param name="id">ID of the character</param>
        /// <param name="name">Name of the character, if found.</param>
        /// <returns>Whether or not the name was found for the given ID.</returns>
        public static bool TryGetNameFromId(string id, out string name) => idToName.TryGetValue(id, out name);

        /// <summary>
        /// Get character name from the character's ID.
        /// </summary>
        /// <param name="id">ID of the character.</param>
        /// <returns>Name of the character with the given ID, or null if not found.</returns>
        public static string GetNameFromId(string id)
        {
            if (TryGetNameFromId(id, out var name))
                return name;
            return null;
        }

        /// <summary>
        /// Get a list of all character IDs.
        /// </summary>
        /// <returns>The list of IDs.</returns>
        public static List<string> GetCharacterIds() => new List<string>(characterIds);

        private static readonly Dictionary<string, string> nameToId = new Dictionary<string, string>
        {
            { "spongebob", "char_apple" },
            { "patrick", "char_star" },
            { "sandy", "char_diver" },
            { "aang", "char_kite" },
            { "korra", "char_athlete" },
            { "toph", "char_clay" },
            { "lincoln loud", "char_rascal" },
            { "lincoln", "char_rascal" },
            { "lucy loud", "char_goth" },
            { "lucy", "char_goth" },
            { "leonardo", "char_moon" },
            { "michelangelo", "char_pizza" },
            { "april o'neil", "char_reporter" },
            { "april oneil", "char_reporter" },
            { "april", "char_reporter" },
            { "ren and stimpy", "char_duo" },
            { "ren & stimpy", "char_duo" },
            { "ren&stimpy", "char_duo" },
            { "powdered toast man", "char_hero" },
            { "powdered toastman", "char_hero" },
            { "ptm", "char_hero" },
            { "invader zim", "char_alien" },
            { "zim", "char_alien" },
            { "catdog", "char_chimera" },
            { "reptar", "char_mascot" },
            { "nigel thornberry", "char_narrator" },
            { "nigel", "char_narrator" },
            { "helga", "char_rival" },
            { "danny phantom", "char_plasma" },
            { "danny", "char_plasma" },
            { "oblina", "char_snake" }
        };

        private static readonly Dictionary<string, string> idToName = new Dictionary<string, string>
        {
            { "char_alien", "Zim" },
            { "char_apple", "SpongeBob" },
            { "char_athlete", "Korra" },
            { "char_chimera", "CatDog" },
            { "char_clay", "Toph" },
            { "char_diver", "Sandy" },
            { "char_duo", "Ren & Stimpy" },
            { "char_goth", "Lucy Loud" },
            { "char_hero", "Powdered Toast Man" },
            { "char_kite", "Aang" },
            { "char_mascot", "Reptar" },
            { "char_moon", "Leonardo" },
            { "char_narrator", "Nigel Thornberry" },
            { "char_pizza", "Michelangelo" },
            { "char_plasma", "Danny Phantom" },
            { "char_rascal", "Lincoln Loud" },
            { "char_reporter", "April O'Neil" },
            { "char_rival", "Helga" },
            { "char_snake", "Oblina" },
            { "char_star", "Patrick" }
        };

        private static readonly string[] characterIds =
        {
            "char_alien",
            "char_apple",
            "char_athlete",
            "char_chimera",
            "char_clay",
            "char_diver",
            "char_duo",
            "char_goth",
            "char_hero",
            "char_kite",
            "char_mascot",
            "char_moon",
            "char_narrator",
            "char_pizza",
            "char_plasma",
            "char_rascal",
            "char_reporter",
            "char_rival",
            "char_snake",
            "char_star"
        };
    }
}
