#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeaponTriangle.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the WeaponTriangle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace StrategyGame.Items.Weapons
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The weapon triangle.
    /// </summary>
    internal static class WeaponTriangle
    {
        /// <summary>
        /// The default weapon triangle.
        /// </summary>
        /// <returns>
        /// The default weapon triangle as a <see cref="Dictionary{TKey,TValue}"/> .
        /// </returns>
        internal static Dictionary<WeaponType, WeaponEffectivity[]> DefaultWeaponTriangle()
        {
            return new Dictionary<WeaponType, WeaponEffectivity[]>(16)
                       {
                               {
                                   WeaponType.Sword,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Lance,
                                   new[]
                                       {
                                           WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Axe,
                                   new[]
                                       {
                                           WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Bow,
                                   new[]
                                       {
                                           WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Dagger,
                                   new[]
                                       {
                                           WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Fire,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Wind,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Thunder,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Light,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Dark,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Claws,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Talons,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Beak,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Strong, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Fangs,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Breath,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Strong, WeaponEffectivity.Weak, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               },
                               {
                                   WeaponType.Staff,
                                   new[]
                                       {
                                           WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral, WeaponEffectivity.Neutral
                                       }
                               }
                       };
        }

        /// <summary>
        /// The inverted weapon triangle.
        /// </summary>
        /// <returns>
        /// The inverted weapon triangle as a <see cref="Dictionary{TKey,TValue}"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Should the weird case happen that the default weapon triangle is broken.
        /// </exception>
        internal static Dictionary<WeaponType, WeaponEffectivity[]> InvertedWeaponTriangle()
        {
            Dictionary<WeaponType, WeaponEffectivity[]> defaultWeaponTriangle = DefaultWeaponTriangle();
            Dictionary<WeaponType, WeaponEffectivity[]> invertedDictionary = new Dictionary<WeaponType, WeaponEffectivity[]>();
            foreach (WeaponType weaponType in defaultWeaponTriangle.Keys)
            {
                List<WeaponEffectivity> invertedEffectivities = new List<WeaponEffectivity>(15);
                foreach (WeaponEffectivity effectivity in defaultWeaponTriangle[weaponType])
                {
                    WeaponEffectivity newEffectivity;
                    switch (effectivity)
                    {
                        case WeaponEffectivity.Neutral:
                            newEffectivity = WeaponEffectivity.Neutral;
                            break;
                        case WeaponEffectivity.Strong:
                            newEffectivity = WeaponEffectivity.Weak;
                            break;
                        case WeaponEffectivity.Weak:
                            newEffectivity = WeaponEffectivity.Strong;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    invertedEffectivities.Add(newEffectivity);
                }

                invertedDictionary.Add(weaponType, invertedEffectivities.ToArray());
            }

            return invertedDictionary;
        }
    }
}