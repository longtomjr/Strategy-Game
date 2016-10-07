// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Items.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Items type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Items
{
    using System.Collections.Generic;

    /// <summary>
    /// The items.
    /// </summary>
    public static class Items
    {
        /// <summary>
        /// Gets the item dictionary, containing all items that should be available at runtime.
        /// </summary>
        public static Dictionary<string, Item> ItemDictionary { get; } = new Dictionary<string, Item>();
    }
}
