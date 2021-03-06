#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Luck.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The luck.
    /// </summary>
    public class Luck : Stat
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Luck"/> class. 
        /// </summary>
        /// <param name="bonus">
        /// The bonus.
        /// </param>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="maximum">
        /// The maximum.
        /// </param>
        public Luck(int bonus, int current, int maximum)
            : base(bonus, current, maximum)
        {
        }
    }
}