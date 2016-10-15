// --------------------------------------------------------------------------------------------------------------------
// <copyright company="SpaceKrakens" file="Tile.cs">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines a Tile.
// </summary> 
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.World
{
    using System;

    using StrategyGame.Characters;

    /// <summary>
    /// The enterability of a tile.
    /// </summary>
    public enum Enterability
    {
        /// <summary>
        /// This tile can be entered by anyone.
        /// </summary>
        Yes,

        /// <summary>
        /// This tile is impassable for anyone.
        /// </summary>
        No,

        /// <summary>
        /// This tile needs more information to determine its enterability for a unit.
        /// </summary>
        Maybe
    }

    /// <summary>
    /// Defines a Tile.
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// The occupying unit.
        /// </summary>
        private Unit occupyingUnit;

        /// <summary>
        /// The changed.
        /// </summary>
        public event Action<Tile> Changed;

        /// <summary>
        /// Gets the tile type.
        /// </summary>
        public string TileType { get; internal set; }

        /// <summary>
        /// Gets the positive or negative impact standing on this tile at the end of the turn has on the unit's health.
        /// </summary>
        public int HealthImpact { get; internal set; }

        public int X { get; internal set; }

        public int Y { get; internal set; }

        /// <summary>
        /// Gets the positive or negative impact standing on this tile while defending or attacking has on the unit's evasion.
        /// </summary>
        public int EvadeImpact { get; internal set; }

        /// <summary>
        /// Gets the function to determine the movement penalty.
        /// </summary>
        public Func<Unit, int> MovementPenalty { get; internal set; }

        /// <summary>
        /// Gets the enterability. If <see cref="Enterability.Yes"/>, anyone can enter this tile. If <see cref="Enterability.No"/>, the tile is impassable for anyone. If <see cref="Enterability.Maybe"/>, a function should be called to determine final enterability.
        /// </summary>
        public Enterability Enterability { get; internal set; }

        /// <summary>
        /// Gets the function to determine <see cref="Enterability"/>, should this tile's Enterability be <see cref="Enterability.Maybe"/>.
        /// </summary>
        public Func<Unit, Enterability> IsEnterable { get; internal set; }

        public Tile()
        {

        }


        /// <summary>
        /// Gets or sets the occupying unit.
        /// </summary>
        public Unit OccupyingUnit
        {
            get
            {
                return this.occupyingUnit;
            }

            set
            {
                this.occupyingUnit = value;
                value.CurrentTile = this;

                this.Changed?.Invoke(this);
            }
        }
    }
}