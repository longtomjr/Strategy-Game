#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WorldController.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

using UnityEngine;

namespace StrategyGame.Controllers
{
    using System.Collections.Generic;

    using StrategyGame.Controllers.Sprites;

    using StrategyGame.World;

    /// <summary>
    /// The controller for everything in the world.
    /// </summary>
    public class WorldController : MonoBehaviour
    {
        /// <summary>
        /// The tile/game object dictionary.
        /// </summary>
        private static Dictionary<Tile, GameObject> tileGameObjectDictionary = new Dictionary<Tile, GameObject>();

        /// <summary>
        /// Runs when the game starts.
        /// </summary>
        public void Start()
        {
            this.InitialiseGameState();
        }

        /// <summary>
        /// Update called by unity. Called every frame.
        /// </summary>
        public void Update()
        {
        }

        /// <summary>
        /// Initialises the game state.
        /// </summary>
        private void InitialiseGameState()
        {
            ////InitialiseClasses();
            ////InitialiseItems();
            ////InitialiseUnits();
            ////InitialiseMap();

            Map debugMap = Debug.TestNumberOne.InitialiseGameState();

            new TileSpriteController(debugMap);

        } 
        /// <summary>
        /// The tile changed callback. It gets called, whenever a tile gets changed.
        /// </summary>
        /// <param name="tile">The tile that got changed.</param>
        private void TileChanged(Tile tile)
        {
            throw new System.NotImplementedException();
        }
    }
}