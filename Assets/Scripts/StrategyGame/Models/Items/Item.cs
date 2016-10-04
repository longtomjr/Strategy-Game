#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Item.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion
namespace StrategyGame.Items
{
    /// <summary>
    /// Base class for all items.
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public abstract string Name { get; }
    }
}
