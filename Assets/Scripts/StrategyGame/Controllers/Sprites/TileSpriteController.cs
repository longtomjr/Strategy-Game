// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TileSpriteController.cs" company="SpaceKrakens">   
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the BaseSpriteController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Controllers.Sprites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using UnityEngine;

    using StrategyGame.World;
    using StrategyGame.Debug;

    public class TileSpriteController : BaseSpriteController<Tile>
    {

        public TileSpriteController(Map map) : base("Tiles")
        {
            foreach (Tile tile in map.Tiles)
            {
                this.OnCreated(tile);
            }
        }

        protected override void OnChanged(Tile obj)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreated(Tile tile)
        {
            GameObject tile_go = new GameObject();
            ObjectGameObjectMap.Add(tile, tile_go);
            tile_go.transform.SetParent(ObjectParent.transform, true);
            tile_go.transform.position = new Vector2(tile.X, tile.Y);
            tile_go.name = $"Tile [{tile.Y} : {tile.X}]";
        }
    }
}
