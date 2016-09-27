// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Faction.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Faction type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Scenarios
{
    using System.Collections.Generic;

    /// <summary>
    /// The faction.
    /// </summary>
    public class Faction
    {
        /// <summary>
        /// Gets or sets the faction id.
        /// </summary>
        public int FactionId { get; set; }

        /// <summary>
        /// Gets or sets the allied factions.
        /// </summary>
        public List<int> AlliedFactions { get; set; }

        /// <summary>
        /// Gets or sets the enemy factions.
        /// </summary>
        public List<int> EnemyFactions { get; set; }
    }
}
