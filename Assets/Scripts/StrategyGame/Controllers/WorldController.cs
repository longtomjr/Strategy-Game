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
    /// <summary>
    /// The controller for everything in the world.
    /// </summary>
    public class WorldController : MonoBehaviour
    {

        /// <summary>
        /// Runs when the game starts.
        /// </summary>
        public void Start()
        {
            InitialiseGameState();
        }

        /// <summary>
        /// Update called by unity. Called every frame.
        /// </summary>
        public void Update()
        {
        }

        private static void InitialiseGameState()
        {
            ////InitialiseClasses();
            ////InitialiseItems();
            ////InitialiseUnits();
            ////InitialiseMap();

            Debug.TestNumberOne.InitialiseGameState();
        }
    }
}