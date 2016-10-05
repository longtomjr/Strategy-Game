// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Unit.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines a Unit.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Characters
{
    using System;
    using System.Collections.Generic;

    using StrategyGame.Characters.Classes;
    using StrategyGame.Interfaces;
    using StrategyGame.Items;
    using StrategyGame.Scenarios;
    using StrategyGame.World;

    /// <summary>
    /// Defines a Unit.
    /// </summary>
    public class Unit : ISelectable
    {
        /// <summary>
        /// The selection information.
        /// </summary>
        private readonly ISelectable selectionInfo;

        /// <summary>
        /// The inventory of the unit.
        /// </summary>
        private readonly Inventory inventory;

        /// <summary>
        /// Initialises a new instance of the <see cref="Unit"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="class">The class.</param>
        /// <param name="stats">The stats.</param>
        /// <param name="startingInventory">The starting Inventory.</param>
        public Unit(string name, string description, Class @class, Stats.Stats stats, IEnumerable<Item> startingInventory = null)
        {
            this.Class = @class;
            this.Stats = stats;
            this.selectionInfo = new SelectionInfo(name, description);
            this.inventory = new Inventory(startingInventory);
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.selectionInfo.Description;
            }

            set
            {
                this.selectionInfo.Description = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.selectionInfo.Name;
            }

            set
            {
                this.selectionInfo.Name = value;
            }
        }

        /// <summary>
        /// Gets the class.
        /// </summary>
        public Class Class { get; internal set; }

        /// <summary>
        /// Gets the stats.
        /// </summary>
        public Stats.Stats Stats { get; }

        /// <summary>
        /// Gets or sets the current tile.
        /// </summary>
        public Tile CurrentTile { get; set; }

        /// <summary>
        /// Gets or sets the current faction.
        /// </summary>
        public Faction CurrentFaction { get; set; }

        /// <summary>
        /// Gets the inventory.
        /// </summary>
        internal Inventory Inventory => this.inventory;

        /// <summary>
        /// Changes the class of a unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <param name="newClass">The new class.</param>
        /// <returns>True, if successful, false, if not.</returns>
        public static bool Reclass(Unit unit, Class newClass)
        {
            return unit?.Reclass(newClass, true) ?? false;
        }

        /// <summary>
        /// Applies the stats of the class to a unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <param name="class">The class.</param>
        /// <returns>True, if successful, false, if not.</returns>
        public static bool ApplyClass(Unit unit, Class @class)
        {
            return unit?.Reclass(@class, false) ?? false;
        }

        /// <summary>
        /// Gets the selection information.
        /// </summary>
        /// <returns>
        /// The <see cref="ISelectable"/>.
        /// </returns>
        public ISelectable Select()
        {
            return this.selectionInfo.Select();
        }

        /// <summary>
        /// The reclass.
        /// </summary>
        /// <param name="newClass">The new class.</param>
        /// <param name="oldClassApplied">The old class applied.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool Reclass(Class newClass, bool oldClassApplied)
        {
            if (newClass == null)
            {
                return false;
            }

            if (oldClassApplied)
            {
                Class oldClass = this.Class;
                this.Stats.Health.Current += newClass.BaseHealth.Current - oldClass.BaseHealth.Current;
                this.Stats.Health.Maximum += newClass.BaseHealth.Maximum - oldClass.BaseHealth.Maximum;
                this.Stats.Strength.Current += newClass.BaseStrength.Current - oldClass.BaseStrength.Current;
                this.Stats.Strength.Maximum += newClass.BaseStrength.Maximum - oldClass.BaseStrength.Maximum;
                this.Stats.Magic.Current += newClass.BaseMagic.Current - oldClass.BaseMagic.Current;
                this.Stats.Magic.Maximum += newClass.BaseMagic.Maximum - oldClass.BaseMagic.Maximum;
                this.Stats.Skill.Current += newClass.BaseSkill.Current - oldClass.BaseSkill.Current;
                this.Stats.Skill.Maximum += newClass.BaseSkill.Maximum - oldClass.BaseSkill.Maximum;
                this.Stats.Speed.Current += newClass.BaseSpeed.Current - oldClass.BaseSpeed.Current;
                this.Stats.Speed.Maximum += newClass.BaseSpeed.Maximum - oldClass.BaseSpeed.Maximum;
                this.Stats.Luck.Current += newClass.BaseLuck.Current - oldClass.BaseLuck.Current;
                this.Stats.Luck.Maximum += newClass.BaseLuck.Maximum - oldClass.BaseLuck.Maximum;
                this.Stats.Defence.Current += newClass.BaseDefence.Current - oldClass.BaseDefence.Current;
                this.Stats.Defence.Maximum += newClass.BaseDefence.Maximum - oldClass.BaseDefence.Maximum;
                this.Stats.Resistance.Current += newClass.BaseResistance.Current - oldClass.BaseResistance.Current;
                this.Stats.Resistance.Maximum += newClass.BaseResistance.Maximum - oldClass.BaseResistance.Maximum;
                this.Stats.Movement.Current += newClass.BaseMoveRange.Current - oldClass.BaseMoveRange.Current;
            }
            else
            {
                this.Stats.Health.Current += newClass.BaseHealth.Current;
                this.Stats.Health.Maximum += newClass.BaseHealth.Maximum;
                this.Stats.Strength.Current += newClass.BaseStrength.Current;
                this.Stats.Strength.Maximum += newClass.BaseStrength.Maximum;
                this.Stats.Magic.Current += newClass.BaseMagic.Current;
                this.Stats.Magic.Maximum += newClass.BaseMagic.Maximum;
                this.Stats.Skill.Current += newClass.BaseSkill.Current;
                this.Stats.Skill.Maximum += newClass.BaseSkill.Maximum;
                this.Stats.Speed.Current += newClass.BaseSpeed.Current;
                this.Stats.Speed.Maximum += newClass.BaseSpeed.Maximum;
                this.Stats.Luck.Current += newClass.BaseLuck.Current;
                this.Stats.Luck.Maximum += newClass.BaseLuck.Maximum;
                this.Stats.Defence.Current += newClass.BaseDefence.Current;
                this.Stats.Defence.Maximum += newClass.BaseDefence.Maximum;
                this.Stats.Resistance.Current += newClass.BaseResistance.Current;
                this.Stats.Resistance.Maximum += newClass.BaseResistance.Maximum;
                this.Stats.Movement.Current += newClass.BaseMoveRange.Current;
            }

            this.Class = newClass;

            return true;
        }
    }
}