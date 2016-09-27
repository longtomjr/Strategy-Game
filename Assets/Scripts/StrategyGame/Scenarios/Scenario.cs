// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Scenario.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Scenario type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Scenarios
{
    using System.Collections.Generic;

    using StrategyGame.Characters;
    using StrategyGame.World;

    /// <summary>
    /// The difficulty setting used by scenarios.
    /// </summary>
    public enum Difficulty
    {
        /// <summary>
        /// The normal.
        /// </summary>
        Normal,

        /// <summary>
        /// The hard.
        /// </summary>
        Hard,

        /// <summary>
        /// The lunatic.
        /// </summary>
        Lunatic,

        /// <summary>
        /// The lunatic plus.
        /// </summary>
        LunaticPlus,

        /// <summary>
        /// The default difficulty.
        /// </summary>
        Default = Normal
    }

    /// <summary>
    /// The scenario.
    /// </summary>
    public class Scenario
    {
        /// <summary>
        /// Gets or sets the other units.
        /// </summary>
        public List<Unit> OtherUnits { get; set; }

        /// <summary>
        /// Gets or sets the coordinates for the ally spot.
        /// </summary>
        public List<Coordinate> AllySpotCoordinates { get; set; }
    }
}
