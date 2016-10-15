// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseSpriteController.cs" company="SpaceKrakens">   
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the BaseSpriteController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using UnityEngine;

namespace StrategyGame.Controllers.Sprites
{
    /// <summary>
    /// The base sprite controller.
    /// Links and tracks pure data and game logic with Unity's visuals.
    /// </summary>
    /// <typeparam name="T">The Type to control.</typeparam>
    public abstract class BaseSpriteController<T>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="BaseSpriteController{T}"/> class.
        /// </summary>
        /// <param name="parentName">The parent name.</param>
        public BaseSpriteController(string parentName)
        {
            this.ObjectParent = new GameObject(parentName);
            this.ObjectGameObjectMap = new Dictionary<T, GameObject>();
        }

        /// <summary>
        /// Gets or sets the object game object map.
        /// </summary>
        protected Dictionary<T, GameObject> ObjectGameObjectMap { get; set; }

        /// <summary>
        /// Gets or sets the object parent.
        /// </summary>
        protected GameObject ObjectParent { get; set; }
    
        /// <summary>
        /// Removes all data currently tracked by the controller.
        /// </summary>
        public virtual void RemoveAll()
        {
            this.ObjectGameObjectMap.Clear();
            GameObject.Destroy(this.ObjectParent);
        }

        /// <summary>
        /// The "created" callback. It gets called, whenever something gets created.
        /// </summary>
        /// <param name="obj">The thing that got created.</param>
        protected abstract void OnCreated(T obj);

        /// <summary>
        /// The "changed" callback. It gets called, whenever something gets changed.
        /// </summary>
        /// <param name="obj">The thing that got changed.</param>
        protected abstract void OnChanged(T obj);
    }
}