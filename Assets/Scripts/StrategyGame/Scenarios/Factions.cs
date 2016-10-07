// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Factions.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Factions type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Scenarios
{
    using System.Collections.Generic;

    /// <summary>
    /// The factions.
    /// </summary>
    public static class Factions
    {
        /// <summary>
        /// Gets a dictionary of all factions.
        /// </summary>
        public static Dictionary<int, Faction> AllFactions { get; } = new Dictionary<int, Faction>();
    }
}
