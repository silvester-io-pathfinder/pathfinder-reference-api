using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class GunslingerWeaponMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Gunslinger Weapon Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You fully understand the best way to utilize your unique weapons. Your proficiency rank increases to master with simple and martial firearms and crossbows. Your proficiency rank for advanced firearms and crossbows, simple weapons, martial weapons, and unarmed attacks increases to expert. You gain access to the critical specialization effects for firearms and crossbows." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 5
                        }
                    }
                },
                Entries = new[] 
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Simple.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Martial.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            WeaponGroupId = WeaponGroups.Instances.Crossbow.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Simple.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            WeaponGroupId = WeaponGroups.Instances.Crossbow.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Martial.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            WeaponGroupId = WeaponGroups.Instances.Crossbow.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Advanced.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Advanced.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainAnyWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Simple.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainAnyWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Martial.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainAnyWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Unarmed.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponGroupSpecializationEffect
                        {
                            Id = Guid.Parse(""),
                            WeaponGroupId = WeaponGroups.Instances.Crossbow.ID,
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponGroupSpecializationEffect
                        {
                            Id = Guid.Parse(""),
                            WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                        }
                    },
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
