using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class ExpertSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Expert Spellcaster", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your fundamental understanding of magic improves, making your spells harder to resist. Your proficiency ranks for arcane spell attack rolls and spell DCs increase to expert." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSpellAttackProficiencyEffect
            {
                Id = Guid.Parse(""), 
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                Prerequisites = new[] 
                { 
                    new EffectPrerequisiteBinding
                    { 
                        Id = Guid.Parse(""), 
                        Prerequisite = new HaveSpecificLevelPrerequisite 
                        { 
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 9
                        } 
                    }
                }
            };

            yield return new GainSpecificSpellDcProficiencyEffect 
            {
                Id = Guid.Parse(""), 
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 9
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
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 42
            };
        }
    }
}
