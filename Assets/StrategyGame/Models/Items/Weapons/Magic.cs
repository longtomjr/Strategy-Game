#region LICENSE
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Magic.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace StrategyGame.Items.Weapons
{
    using StrategyGame.Items.Ranks;
    using StrategyGame.Items.Weapons.Materials;

    /// <summary>
    /// Magic Weapon Class.
    /// </summary>
    public class Magic : Weapon
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Magic"/> class.
        /// </summary>
        /// <param name="weaponType">The weapon type.</param>
        /// <param name="material">The material.</param>
        /// <param name="stats">The stats of the weapon</param>
        /// <param name="requiredWeaponRank">The required Weapon Rank.</param>
        /// <param name="weaponTriangleIsDefault">The value indicating whether the default weapon triangle should be used. Defaults to <code>true</code>.</param>
        /// <param name="nameIsDefault">The value indicating whether the default name should be used. Defaults to <code>true</code>.</param>
        /// <param name="uniqueName">The unique Name. Defaults to <code>null</code>.</param>
        public Magic(
            WeaponType weaponType,
            MagicMaterial material,
            Stats stats,
            Rank requiredWeaponRank,
            bool weaponTriangleIsDefault = true,
            bool nameIsDefault = true,
            string uniqueName = null)
            : base(weaponType, material, stats, requiredWeaponRank, true, weaponTriangleIsDefault, nameIsDefault, uniqueName)
        {
        }
    }
}
