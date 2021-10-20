using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class ArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11, 
                Name = "Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have spent so much time in armor that you know how to make the most of its protection. Your proficiency ranks for light, medium, and heavy armor, as well as for unarmored defense, increase to expert. You gain the armor specialization effects of medium and heavy armor." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite {Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11}
                    }
                }
            };

            yield return new GainSpecificArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite {Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11}
                    }
                }
            };

            yield return new GainSpecificArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite {Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11}
                    }
                }
            };

            yield return new GainSpecificArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                ArmorCategoryId = ArmorCategories.Instances.Unarmored.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite {Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11}
                    }
                }
            };

            yield return new GainSpecificArmorCategorySpecializationEffect
            {
                Id = Guid.Parse(""),
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite {Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11}
                    }
                }
            };

            yield return new GainSpecificArmorCategorySpecializationEffect
            {
                Id = Guid.Parse(""),
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite {Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11}
                    }
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
