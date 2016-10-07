#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Health.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace StrategyGame.Characters.Stats
{
    /// <summary>
    /// The health.
    /// </summary>
    public class Health : Stat
    {
        /// <summary>
        /// The actual health modifier.
        /// </summary>
        private int actualHealthModifier;

        /// <summary>
        /// Initialises a new instance of the <see cref="Health"/> class. 
        /// </summary>
        /// <param name="current">The current.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="growthRate">The growth rate.</param>
        /// <param name="bonus">The bonus.</param>
        public Health(int current, int maximum, float growthRate, int bonus = 0)
            : base(current, maximum, growthRate, bonus)
        {
        }

        /// <summary>
        /// Gets or sets the actual health.
        /// </summary>
        public int Actual
        {
            get
            {
                return this + this.actualHealthModifier;
            }

            set
            {
                this.actualHealthModifier = value - this.Actual;
            }
        }

        /// <summary>
        /// Adds the amount of i to the current health.
        /// </summary>
        /// <param name="stat">The health stat.</param>
        /// <param name="i">An integer value.</param>
        /// <returns>The stat itself.</returns>
        public static Health operator +(Health stat, int i)
        {
            if (stat.Actual + i <= stat)
            {
                stat.Actual += i;
            }

            return stat;
        }

        /// <summary>
        /// Subtracts the amount of i from the current health.
        /// </summary>
        /// <param name="stat">The health stat.</param>
        /// <param name="i">An integer value.</param>
        /// <returns>The stat itself.</returns>
        public static Health operator -(Health stat, int i)
        {
            stat.Actual -= i;
            
            return stat;
        }
    }
}