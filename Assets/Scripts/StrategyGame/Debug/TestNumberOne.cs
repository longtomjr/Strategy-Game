// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestNumberOne.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the TestNumberOne type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StrategyGame.Debug
{
    using System.Collections.Generic;

    using StrategyGame.Characters;
    using StrategyGame.Characters.Classes;
    using StrategyGame.Characters.Stats;
    using StrategyGame.Items;
    using StrategyGame.Items.Ranks;
    using StrategyGame.Items.Weapons;
    using StrategyGame.Items.Weapons.Materials;
    using StrategyGame.Scenarios;
    using StrategyGame.World;

    using Magic = Characters.Stats.Magic;

    /// <summary>
    /// Test class number one. To initialise everything without actually using SKON.
    /// </summary>
    public static class TestNumberOne
    {
        public static Map InitialiseGameState()
        {
            InitialiseClasses();
            InitialiseItems();
            InitialiseFactions();
            InitialiseUnits();
            return InitialiseMap();
        }

        private static void InitialiseFactions()
        {
            Faction ally01 = new Faction();
            Faction enemy01 = new Faction();
            ally01.EnemyFactions.Add(enemy01.FactionId);
            enemy01.EnemyFactions.Add(ally01.FactionId);
        }

        private static Map InitialiseMap()
        {
            Unit enemyUnitDefault = new Unit(
                name: "Rey", 
                description: "An aspiring fighter, and the childhood friend of Titan.", 
                @class: Classes.ClassDictionary["Fighter"], 
                stats: new StrategyGame.Characters.Stats.Stats(
                    health: new Health(current: 2, maximum: 0, growthRate: 0.45f), 
                    strength: new Strength(current: 2, maximum: 3, growthRate: 0.5f), 
                    magic: new Magic(current: 0, maximum: 0, growthRate: 0.1f), 
                    skill: new Skill(current: 1, maximum: 0, growthRate: 0.3f),
                    speed: new Speed(current: 1, maximum: 1, growthRate: 0.25f),
                    luck: new Luck(current: 4, maximum: 1, growthRate: 0.65f), 
                    defence: new Defence(current: 1, maximum: 0, growthRate: 0.4f), 
                    resistance: new Resistance(current: 1, maximum: -1, growthRate: 0.2f),
                    movement: new Movement(current: 0), 
                    level: new Level(current: 1, maximum: 20), 
                    weaponRanks: new List<Rank>[]
                                     {
                                         new List<Rank>(Classes.ClassDictionary["Fighter"].Ranks[0]),
                                         new List<Rank>(Classes.ClassDictionary["Fighter"].Ranks[0]),
                                         new List<Rank>(Classes.ClassDictionary["Fighter"].Ranks[1]),
                                     }))
                                        {
                                            CurrentFaction = Factions.AllFactions[1]
                                        };

            enemyUnitDefault.Stats.WeaponRanks[1][0].Experience = 69;
            enemyUnitDefault.Stats.WeaponRanks[1][0].Level = 1;
            enemyUnitDefault.Inventory.EquipItem(Items.ItemDictionary["Training Axe"]);
            enemyUnitDefault.Stats.RegisterWeapon((Weapon)Items.ItemDictionary["Training Axe"]);
            Unit.ApplyClass(enemyUnitDefault, enemyUnitDefault.Class);

            Map testMap = new Map
            {
                Tiles = new[,]
                            {
                                    {
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 0,
                                                X = 0
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 0,
                                                X = 1
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 0,
                                                X = 2

                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 0,
                                                X = 3
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 0,
                                                X = 4
                                            }
                                    },
                                    {
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 1,
                                                X = 0
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 1,
                                                X = 1
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 1,
                                                X = 2
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 1,
                                                X = 3
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 1,
                                                X = 4
                                            }
                                    },
                                    {
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 2,
                                                X = 0
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 2,
                                                X = 1
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 2,
                                                X = 2
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 2,
                                                X = 3

                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 2,
                                                X = 4
                                            }
                                    },
                                    {
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 3,
                                                X = 0
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 3,
                                                X = 1
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 3,
                                                X = 2
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 3,
                                                X = 3
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 3,
                                                X = 4
                                            }
                                    },
                                    {
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 4,
                                                X = 0
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 4,
                                                X = 1
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 4,
                                                X = 2
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 4,
                                                X = 3
                                            },
                                        new Tile
                                            {
                                                Enterability = Enterability.Yes,
                                                EvadeImpact = 0,
                                                HealthImpact = 0,
                                                IsEnterable = (unit) => Enterability.Yes,
                                                MovementPenalty = (unit) => 0,
                                                TileType = "Dirt",
                                                Y = 4,
                                                X = 4
                                            }
                                    }
                            },
                Scenarios = new Dictionary<Difficulty, Scenario>()
                                {
                                        {
                                            Difficulty.Default, new Scenario()
                                                                    {
                                                                        OtherUnits = new Dictionary<Coordinate, Unit>()
                                                                                         {
                                                                                                 {
                                                                                                     new Coordinate()
                                                                                                         {
                                                                                                             X = 3,
                                                                                                             Y = 3
                                                                                                         },
                                                                                                     enemyUnitDefault
                                                                                                 } 
                                                                                         },
                                                                        AllySpotCoordinates = new List<Coordinate>()
                                                                                                  {
                                                                                                      new Coordinate()
                                                                                                          {
                                                                                                              X = 3,
                                                                                                              Y = 1
                                                                                                          }
                                                                                                  }
                                                                    }
                                        }
                                }
            };

            return testMap;
        }

        private static void InitialiseUnits()
        {
            Unit character = new Unit(
                name: "Titan", 
                description: "A young noble, learning the art of war and combat.", 
                @class: Classes.ClassDictionary["Lord"], 
                stats: new StrategyGame.Characters.Stats.Stats(
                    health: new Health(current: 2, maximum: 0, growthRate: 0.45f),
                    strength: new Strength(current: 1, maximum: 1, growthRate: 0.4f),
                    magic: new Magic(current: 1, maximum: 0, growthRate: 0.1f),
                    skill: new Skill(current: 3, maximum: 1, growthRate: 0.4f),
                    speed: new Speed(current: 1, maximum: 1, growthRate: 0.4f),
                    luck: new Luck(current: 5, maximum: 1, growthRate: 0.7f),
                    defence: new Defence(current: 0, maximum: -1, growthRate: 0.35f),
                    resistance: new Resistance(current: 1, maximum: -1, growthRate: 0.2f),
                    movement: new Movement(current: 0),
                    level: new Level(current: 1, maximum: 20),
                    weaponRanks: new List<Rank>[]
                                     {
                                         new List<Rank>(Classes.ClassDictionary["Lord"].Ranks[0]), 
                                         new List<Rank>(Classes.ClassDictionary["Lord"].Ranks[0]),
                                         new List<Rank>(Classes.ClassDictionary["Lord"].Ranks[1]),  
                                     }));
            character.Stats.WeaponRanks[1][0].Experience = 69;
            character.Stats.WeaponRanks[1][0].Level = 1;
            character.Inventory.EquipItem(Items.ItemDictionary["Training Sword"]);
            character.Stats.RegisterWeapon((Weapon)Items.ItemDictionary["Training Sword"]);
            character.CurrentFaction = Factions.AllFactions[0];
            Unit.ApplyClass(character, character.Class);

            Units.UnitDictionary.Add(character);
        }

        private static void InitialiseItems()
        {
            Item trainingSword = new Regular(
                weaponType: WeaponType.Sword, 
                material: WeaponMaterial.Bronze, 
                stats: new StrategyGame.Items.Weapons.Stats(
                    might: 4, 
                    hitChance: 100, 
                    critChance: null, 
                    avoidChance: 10, 
                    minimumRange: 1, 
                    maximumRange: 1), 
                requiredWeaponRank: Ranks.RankDictionary["Sword_E"], 
                nameIsDefault: false, 
                uniqueName: "Training Sword");

            Item trainingAxe = new Regular(
                weaponType: WeaponType.Axe,
                material: WeaponMaterial.Bronze,
                stats: new StrategyGame.Items.Weapons.Stats(
                    might: 6,
                    hitChance: 80,
                    critChance: null,
                    avoidChance: 0,
                    minimumRange: 1,
                    maximumRange: 1),
                requiredWeaponRank: Ranks.RankDictionary["Axe_E"],
                nameIsDefault: false,
                uniqueName: "Training Axe");

            Items.ItemDictionary.Add(trainingSword.Name, trainingSword);
            Items.ItemDictionary.Add(trainingAxe.Name, trainingAxe);
        }

        private static void InitialiseClasses()
        {
            #region great lord
            Class greatLord = new Class(
                                  baseHealth: new Health(current: 23, maximum: 80, growthRate: 0.4f),
                                  baseStrength: new Strength(current: 10, maximum: 43, growthRate: 0.2f),
                                  baseMagic: new Magic(current: 0, maximum: 30, growthRate: 0),
                                  baseSkill: new Skill(current: 7, maximum: 40, growthRate: 0.2f),
                                  baseSpeed: new Speed(current: 9, maximum: 41, growthRate: 0.2f),
                                  baseLuck: new Luck(current: 0, maximum: 45, growthRate: 0),
                                  baseDefence: new Defence(current: 10, maximum: 42, growthRate: 0.1f),
                                  baseResistance: new Resistance(current: 3, maximum: 40, growthRate: 0.05f),
                                  baseMoveRange: new Movement(current: 6),
                                  isBaseClass: false,
                                  isSpecialClass: false,
                                  secondTierClasses: new List<Class>(),
                                  ranks: new[]
                                             {
                                                 new List<Rank>()
                                                     {
                                                         Ranks.RankDictionary["Sword_E"],
                                                         Ranks.RankDictionary["Lance_E"]
                                                     }, 
                                                 new List<Rank>()
                                                     {
                                                         Ranks.RankDictionary["Sword_A"],
                                                         Ranks.RankDictionary["Lance_A"]
                                                     }
                                             });
            #endregion
            #region hero
            Class hero = new Class(
                             baseHealth: new Health(current: 22, maximum: 80, growthRate: 0.45f),
                             baseStrength: new Strength(current: 8, maximum: 42, growthRate: 0.2f),
                             baseMagic: new Magic(current: 1, maximum: 30, growthRate: 0),
                             baseSkill: new Skill(current: 11, maximum: 46, growthRate: 0.25f),
                             baseSpeed: new Speed(current: 10, maximum: 42, growthRate: 0.2f),
                             baseLuck: new Luck(current: 0, maximum: 45, growthRate: 0),
                             baseDefence: new Defence(current: 8, maximum: 40, growthRate: 0.1f),
                             baseResistance: new Resistance(current: 3, maximum: 36, growthRate: 0.05f),
                             baseMoveRange: new Movement(current: 6),
                             isBaseClass: false,
                             isSpecialClass: false,
                             secondTierClasses: new List<Class>(),
                             ranks: new[]
                                        {
                                            new List<Rank>()
                                                {
                                                    Ranks.RankDictionary["Sword_E"],
                                                    Ranks.RankDictionary["Axe_E"]
                                                },
                                            new List<Rank>()
                                                {
                                                    Ranks.RankDictionary["Sword_A"],
                                                    Ranks.RankDictionary["Axe_A"]
                                                }
                                        });
            #endregion
            #region warrior
            Class warrior = new Class(
                                baseHealth: new Health(current: 28, maximum: 80, growthRate: 0.45f),
                                baseStrength: new Strength(current: 12, maximum: 48, growthRate: 0.25f),
                                baseMagic: new Magic(current: 0, maximum: 30, growthRate: 0),
                                baseSkill: new Skill(current: 8, maximum: 42, growthRate: 0.2f),
                                baseSpeed: new Speed(current: 7, maximum: 40, growthRate: 0.15f),
                                baseLuck: new Luck(current: 0, maximum: 45, growthRate: 0),
                                baseDefence: new Defence(current: 7, maximum: 40, growthRate: 0.1f),
                                baseResistance: new Resistance(current: 3, maximum: 35, growthRate: 0.05f),
                                baseMoveRange: new Movement(current: 6),
                                isBaseClass: false,
                                isSpecialClass: false,
                                secondTierClasses: new List<Class>(),
                                ranks: new[]
                                           {
                                               new List<Rank>()
                                                   {
                                                       Ranks.RankDictionary["Axe_E"],
                                                       Ranks.RankDictionary["Bow_E"]
                                                   },
                                               new List<Rank>()
                                                   {
                                                       Ranks.RankDictionary["Axe_A"],
                                                       Ranks.RankDictionary["Bow_A"]
                                                   }
                                           });
            #endregion
            #region lord
            Class lord = new Class(
                             baseHealth: new Health(current: 18, maximum: 60, growthRate: 0.4f),
                             baseStrength: new Strength(current: 6, maximum: 28, growthRate: 0.2f),
                             baseMagic: new Magic(current: 0, maximum: 20, growthRate: 0),
                             baseSkill: new Skill(current: 5, maximum: 26, growthRate: 0.2f),
                             baseSpeed: new Speed(current: 7, maximum: 27, growthRate: 0.2f),
                             baseLuck: new Luck(current: 0, maximum: 31, growthRate: 0),
                             baseDefence: new Defence(current: 7, maximum: 25, growthRate: 0.1f),
                             baseResistance: new Resistance(current: 0, maximum: 25, growthRate: 0.05f),
                             baseMoveRange: new Movement(current: 5),
                             isBaseClass: true,
                             isSpecialClass: false,
                             secondTierClasses: new List<Class>()
                                                    {
                                                        greatLord
                                                    },
                             ranks: new[]
                                        {
                                            new List<Rank>()
                                                {
                                                    Ranks.RankDictionary["Sword_E"]
                                                },
                                            new List<Rank>()
                                                {
                                                    Ranks.RankDictionary["Sword_A"]
                                                }
                                        });
            #endregion
            #region fighter
            Class fighter = new Class(
                                baseHealth: new Health(current: 20, maximum: 60, growthRate: 0.45f),
                                baseStrength: new Strength(current: 8, maximum: 29, growthRate: 0.25f),
                                baseMagic: new Magic(current: 0, maximum: 20, growthRate: 0),
                                baseSkill: new Skill(current: 5, maximum: 26, growthRate: 0.2f),
                                baseSpeed: new Speed(current: 5, maximum: 25, growthRate: 0.15f),
                                baseLuck: new Luck(current: 0, maximum: 30, growthRate: 0),
                                baseDefence: new Defence(current: 4, maximum: 25, growthRate: 0.1f),
                                baseResistance: new Resistance(current: 0, maximum: 23, growthRate: 0.05f),
                                baseMoveRange: new Movement(current: 5),
                                isBaseClass: true,
                                isSpecialClass: false,
                                secondTierClasses: new List<Class>()
                                                       {
                                                           hero,
                                                           warrior
                                                       },
                                ranks: new[]
                                           {
                                               new List<Rank>()
                                                   {
                                                       Ranks.RankDictionary["Axe_E"]
                                                   },
                                               new List<Rank>()
                                                   {
                                                       Ranks.RankDictionary["Axe_A"]
                                                   }
                                           });
            #endregion
            Classes.ClassDictionary.Add("Lord", lord);
            Classes.ClassDictionary.Add("Fighter", fighter);
            Classes.ClassDictionary.Add("Great Lord", greatLord);
            Classes.ClassDictionary.Add("Warrior", warrior);
            Classes.ClassDictionary.Add("Hero", hero);
        }
    }
}
