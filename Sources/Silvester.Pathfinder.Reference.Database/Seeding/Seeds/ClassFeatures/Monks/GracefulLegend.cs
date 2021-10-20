using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class GracefulLegend : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Graceful Legend", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your sublime movement grants you unparalleled protection and offense. Your proficiency rank for unarmored defense increases to legendary, and your proficiency rank for your monk class DC increases to master. If you have ki spells, your proficiency rank for spell attack rolls and spell DCs with the tradition of magic you use for your ki spells increases to master." };
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
                            RequiredLevel = 13
                        }
                    }
                }, 
                Entries = new [] 
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificArmorCategoryProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Legendary.ID, ArmorCategoryId = ArmorCategories.Instances.Unarmored.ID }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificClassDcProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Master.ID }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellAttackProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Master.ID }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellDcProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Master.ID }
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
                Page = 158
            };
        }
    }
}
