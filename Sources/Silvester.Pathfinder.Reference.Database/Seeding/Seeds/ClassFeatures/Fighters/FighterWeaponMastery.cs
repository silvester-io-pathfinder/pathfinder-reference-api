using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class FighterWeaponMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Fighter Weapon Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Hours spent training with your preferred weapons, learning and developing new combat techniques, have made you particularly effective with your weapons of choice. Choose one weapon group. Your proficiency rank increases to master with the simple weapons, martial weapons, and unarmed attacks in that group, and to expert with the advanced weapons in that group. You gain access to the critical specialization effects of all weapons and unarmed attacks for which you have master proficiency." };
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
                        Effect = new GainAnyWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Simple.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainAnyWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Martial.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainAnyWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Unarmed.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainAnyWeaponGroupProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Advanced.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainAnyWeaponCategorySpecializationEffect
                        {
                            Id = Guid.Parse(""),
                            Prerequisites = new [] 
                            {
                                new EffectPrerequisiteBinding
                                {
                                    Id = Guid.Parse(""),
                                    Prerequisite = new HaveCurrentWeaponProficiencyPrerequisite
                                    {
                                        Id = Guid.Parse(""),
                                        RequiredProficiencyId = Proficiencies.Instances.Master.ID
                                    }
                                }
                            }
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
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
