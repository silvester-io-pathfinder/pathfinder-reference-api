using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Doctrines.Instances
{
    public class Warpriest : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Doctrine GetDoctrine()
        {
            return new Doctrine
            {
                Id = ID,
                Name = "Warpriest",
                Description = "You have trained in the more militant doctrine of your church, focusing on both spells and battle."
            };
        }

        public override IEnumerable<Effect> GetEffects()
        {
            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "First Doctrine",
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificArmorCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Trained.ID,
                            ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificArmorCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Trained.ID,
                            ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSavingThrowProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificFeatEffect
                        {
                            Id = Guid.Parse(""),
                            FeatId = Feats.Instances.ShieldBlock.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificFeatEffect
                        {
                            Id = Guid.Parse(""),
                            FeatId = Feats.Instances.DeadlySimplicity.ID,
                            Prerequisites = new []
                            {
                                new EffectPrerequisiteBinding
                                {
                                    Id = Guid.Parse(""),
                                    Prerequisite = new HaveSpecificDeityWeaponCategoryPrerequisite {Id = Guid.Parse(""), WeaponCategoryId = WeaponCategories.Instances.Simple.ID }
                                }
                            }
                        },
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificArmorCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                            Prerequisites = new [] 
                            {
                                new EffectPrerequisiteBinding 
                                {
                                    Id = Guid.Parse(""), 
                                    Prerequisite = new HaveSpecificLevelPrerequisite {Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13 }
                                }
                            }
                        },
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificArmorCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                            Prerequisites = new []
                            {
                                new EffectPrerequisiteBinding
                                {
                                    Id = Guid.Parse(""),
                                    Prerequisite = new HaveSpecificLevelPrerequisite {Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13 }
                                }
                            }
                        }
                    },
                }
            };

            yield return new GainSpecificWeaponCategoryProficiencyEffect
            {
                Id = Guid.Parse(""),
                Name = "Second Doctrine",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 3 }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "Third Doctrine",
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 7 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainDeityFavoredWeaponProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainDeityFavoredWeaponSpecializationEffect
                        {
                            Id = Guid.Parse(""),
                        }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "Fourth Doctrine",
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellAttackProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellDcProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                        }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "Fifth Doctrine",
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 15 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSavingThrowProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new ModifySpecificSavingThrowEffect
                        {
                            Id = Guid.Parse(""),
                            InitialResult = RollResult.Success,
                            Becomes = RollResult.CriticalSuccess,
                            SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID
                        }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "Final Doctrine",
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 19 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellAttackProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellDcProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                        }
                    }
                }
            };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 120
            };
        }
    }
}
