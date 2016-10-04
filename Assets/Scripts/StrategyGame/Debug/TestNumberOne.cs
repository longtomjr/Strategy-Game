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

    using Magic = StrategyGame.Characters.Stats.Magic;

    /// <summary>
    /// Test class number one. To initialise everything without actually using SKON.
    /// </summary>
    public static class TestNumberOne
    {
        public static void InitialiseGameState()
        {
            InitialiseClasses();
            InitialiseItems();
            InitialiseUnits();
            InitialiseMap();
        }

        private static void InitialiseMap()
        {
            throw new System.NotImplementedException();
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
                    weaponRanks: new List<Rank>()));
            character.Stats.WeaponRanks.AddRange(Classes.ClassDictionary["Lord"].Ranks[0]);
            character.Stats.WeaponRanks[0].Experience = 33;
            character.Stats.WeaponRanks[0].Level = 1;

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
