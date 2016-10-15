// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Map.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines a Map made of Tiles.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.World
{
    using System.Collections.Generic;

    using StrategyGame.Scenarios;

    /// <summary>
    /// Defines a Map made of Tiles.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Map"/> class.
        /// Dummy constructor for use in Serialisation.
        /// </summary>
        public Map()
        {
            this.Tiles = new Tile[,] { };
            this.Scenarios = new Dictionary<Difficulty, Scenario>();
        }

        /// <summary>
        /// Gets or sets the tiles.
        /// </summary>
        public Tile[,] Tiles { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of scenarios keyed with the appropriate difficulty.
        /// </summary>
        public Dictionary<Difficulty, Scenario> Scenarios { get; set; }
    }
}
