// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Classes.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Classes type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Characters.Classes
{
    using System.Collections.Generic;

    /// <summary>
    /// Static container class for all classes available at runtime.
    /// </summary>
    public static class Classes
    {
        /// <summary>
        /// Gets the class dictionary, containing all classes that should be available at runtime.
        /// </summary>
        public static Dictionary<string, Class> ClassDictionary { get; } = new Dictionary<string, Class>();
    }
}
