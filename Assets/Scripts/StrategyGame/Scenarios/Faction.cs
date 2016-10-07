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
        /// The id counter.
        /// </summary>
        private static int idCounter = 0;

        /// <summary>
        /// Initialises a new instance of the <see cref="Faction"/> class.
        /// </summary>
        public Faction()
        {
            this.FactionId = idCounter++;
            Factions.AllFactions.Add(this.FactionId, this);
        }

        /// <summary>
        /// Gets the faction id.
        /// </summary>
        public int FactionId { get; }

        /// <summary>
        /// Gets or sets the allied factions.
        /// </summary>
        public List<int> AlliedFactions { get; set; } = new List<int>();

        /// <summary>
        /// Gets or sets the enemy factions.
        /// </summary>
        public List<int> EnemyFactions { get; set; } = new List<int>();
    }
}
