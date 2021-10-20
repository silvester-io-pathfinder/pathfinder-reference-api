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
    public class SingularExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Singular Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have particular expertise with guns and crossbows that grants you greater proficiency with them and the ability to deal more damage. You gain a +1 circumstance bonus to damage rolls with firearms and crossbows." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "This intense focus on firearms and crossbows prevents you from reaching the same heights with other weapons. Your proficiency with unarmed attacks and with weapons other than firearms and crossbows can't be higher than trained, even if you gain an ability that would increase your proficiency in one or more other weapons to match your highest weapon proficiency (such as the weapon expertise feats many ancestries have). If you have gunslinger weapon mastery, the limit is expert, and if you have gunslinging legend, the limit is master." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificWeaponGroupCircumstanceBonusEffect
            {
                Id = Guid.Parse(""),
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                RollType = RollType.Attack,
                Bonus = 1
            };

            yield return new GainSpecificWeaponGroupCircumstanceBonusEffect
            {
                Id = Guid.Parse(""),
                WeaponGroupId = WeaponGroups.Instances.Crossbow.ID,
                RollType = RollType.Attack,
                Bonus = 1
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.LessThan, RequiredLevel = 5 }
                    }
                },
                Entries = new []
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSingularExpertiseEffect
                        {
                            Id = Guid.Parse(""),
                            WeaponGroupId = WeaponGroups.Instances.Crossbow.ID,
                            HighestProficiencyId = Proficiencies.Instances.Trained.ID,

                        }
                    }, 
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSingularExpertiseEffect
                        {
                            Id = Guid.Parse(""),
                            WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                            HighestProficiencyId = Proficiencies.Instances.Trained.ID,
                        }
                    },
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.LessThan, RequiredLevel = 13 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSingularExpertiseEffect
                        {
                            Id = Guid.Parse(""),
                            WeaponGroupId = WeaponGroups.Instances.Crossbow.ID,
                            HighestProficiencyId = Proficiencies.Instances.Expert.ID,

                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSingularExpertiseEffect
                        {
                            Id = Guid.Parse(""),
                            WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                            HighestProficiencyId = Proficiencies.Instances.Expert.ID,
                        }
                    },
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSingularExpertiseEffect
                        {
                            Id = Guid.Parse(""),
                            WeaponGroupId = WeaponGroups.Instances.Crossbow.ID,
                            HighestProficiencyId = Proficiencies.Instances.Master.ID,

                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSingularExpertiseEffect
                        {
                            Id = Guid.Parse(""),
                            WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                            HighestProficiencyId = Proficiencies.Instances.Master.ID,
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
