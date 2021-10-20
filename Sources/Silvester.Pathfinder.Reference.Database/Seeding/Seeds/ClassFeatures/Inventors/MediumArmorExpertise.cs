using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class MediumArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Medium Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've learned to better defend yourself against attacks. Your proficiency ranks for light armor, medium armor, and unarmored defense increase to expert." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you have a medium or heavy armor innovation, you gain access to the critical specialization effect with your armor innovation." };
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
                            RequiredLevel = 11
                        }
                    }
                },
                Entries = new[] 
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificArmorCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,

                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificArmorCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,

                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificArmorCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                            ArmorCategoryId = ArmorCategories.Instances.Unarmored.ID,

                        }
                    }
                }
            };

            yield return new GainInnovationArmorSpecializationEffect
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
                            RequiredLevel = 11
                        }
                    },
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificInnovationPrerequisite
                        {
                            Id = Guid.Parse(""),
                            InnovationId = Innovations.Instances.ArmorInnovation.ID
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 22
            };
        }
    }
}
