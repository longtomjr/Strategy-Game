// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Units.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Units type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Characters
{
    using System.Collections.Generic;

    /// <summary>
    /// The units.
    /// </summary>
    public static class Units
    {
        /// <summary>
        /// Gets the unit dictionary, containing all units that should be available at runtime.
        /// </summary>
        public static List<Unit> UnitDictionary { get; } = new List<Unit>();
    }
}
