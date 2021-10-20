using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class InventiveExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Investigator Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've refined your investigative techniques to an exceptional degree. Your circumstance bonus from Pursue a Lead increases to +2. Your proficiency rank for your investigator class DC increases to expert." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificClassDcProficiencyEffect
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

            //TODO: Add the +2 circumstance bonus to Pursue a Lead.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
