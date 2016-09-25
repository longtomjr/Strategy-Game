// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombatPreviewInfo.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the CombatPreviewInfo type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.Combat
{
    using System;

    using Assets.Scripts.Models.Characters;
    using Assets.Scripts.Models.Items.Weapons;

    /// <summary>
    /// The combattant IDs.
    /// </summary>
    public enum CombattantIDs
    {
        /// <summary>
        /// The attacker.
        /// </summary>
        Attacker = 0,

        /// <summary>
        /// The attack supporter.
        /// </summary>
        AttackSupporter = 1,

        /// <summary>
        /// The defender.
        /// </summary>
        Defender = 2,

        /// <summary>
        /// The defence supporter.
        /// </summary>
        DefenceSupporter = 3
    }

    /// <summary>
    /// Calculates all necessary information accessible through the combat preview.
    /// </summary>
    public class CombatPreviewInfo
    {

        /// <summary>
        /// Initialises a new instance of the <see cref="CombatPreviewInfo"/> class.
        /// </summary>
        /// <param name="combattants">The combattants. Must always be an array of length 4 with <code>null</code> values for missing combattants.</param>
        public CombatPreviewInfo(Unit[] combattants)
        {
            if (combattants == null)
            {
                throw new ArgumentNullException(nameof(combattants), "The given array for the combattant data cannot be null.");
            }

            if (combattants.Length != 4)
            {
                throw new ArgumentException("The given array for the combattant data was not of length four.", nameof(combattants));
            }

            this.AmountHits = new int?[4];
            this.Damage = new int?[4];
            this.HitChance = new int?[4];
            this.CritChance = new int?[4];
            for (int i = 0; i < 4; i++)
            {
                this.InitialiseArrays(i, combattants);
            }
        }

        /// <summary>
        /// Gets the amount of hits.
        /// </summary>
        public int?[] AmountHits { get; }

        /// <summary>
        /// Gets the pure damage dealt with one hit.
        /// </summary>
        public int?[] Damage { get; }

        /// <summary>
        /// Gets the hit chance per hit.
        /// </summary>
        public int?[] HitChance { get; }

        /// <summary>
        /// Gets the crit chance per hit. Crits are only possible if the unit actually hits.
        /// </summary>
        public int?[] CritChance { get; }

        /// <summary>
        /// Initialises the four arrays instantiated by the constructor.
        /// </summary>
        /// <param name="combattantId">The combattant id.</param>
        /// <param name="combattants">The combattants.</param>
        private void InitialiseArrays(int combattantId, Unit[] combattants)
        {
            Weapon weapon = combattants[combattantId]?.Inventory.GetItem(0) as Weapon;
            if (weapon != null)
            {
                if (combattantId < 2)
                {
                    this.AmountHits[combattantId] = (combattants[combattantId].Stats.Speed >= combattants[2].Stats.Speed + 5 ? 2 : 1) * weapon.Stats.AmountHits;
                    this.Damage[combattantId] = Math.Max(combattants[combattantId].Stats.AttackDamage - (weapon.IsMagical ? (int)combattants[2].Stats.Resistance : (int)combattants[2].Stats.Defence), 0);
                    this.HitChance[combattantId] = Math.Max(combattants[combattantId].Stats.Hit - combattants[2].Stats.Evade, 0);
                    this.CritChance[combattantId] = Math.Max(combattants[combattantId].Stats.Crit - combattants[2].Stats.CritEvade, 0);
                }
                else
                {
                    this.AmountHits[combattantId] = (combattants[combattantId].Stats.Speed >= combattants[0].Stats.Speed + 5 ? 2 : 1) * weapon.Stats.AmountHits;
                    this.Damage[combattantId] = Math.Max(combattants[combattantId].Stats.AttackDamage - (weapon.IsMagical ? (int)combattants[0].Stats.Resistance : (int)combattants[0].Stats.Defence), 0);
                    this.HitChance[combattantId] = Math.Max(combattants[combattantId].Stats.Hit - combattants[0].Stats.Evade, 0);
                    this.CritChance[combattantId] = Math.Max(combattants[combattantId].Stats.Crit - combattants[0].Stats.CritEvade, 0);
                }
            }
            else
            {
                this.AmountHits[combattantId] = null;
                this.Damage[combattantId] = null;
                this.HitChance[combattantId] = null;
                this.CritChance[combattantId] = null;
            }
        }
    }
}
