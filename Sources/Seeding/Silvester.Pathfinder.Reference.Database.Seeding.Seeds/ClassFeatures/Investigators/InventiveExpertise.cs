using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class InventiveExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("1574ed5b-ca48-435d-acc2-4551402dc70c");

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
            yield return new TextBlock { Id = Guid.Parse("12cb5f6b-0d47-42a5-8971-bb1dcab4f135"), Type = TextBlockType.Text, Text = "You've refined your investigative techniques to an exceptional degree. Your circumstance bonus from Pursue a Lead increases to +2. Your proficiency rank for your investigator class DC increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("041f7b36-d1b1-46a0-a694-9a986237bb97"), Proficiencies.Instances.Expert.ID);
            //TODO: Add the +2 circumstance bonus to Pursue a Lead.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3be96441-d0f4-4bb9-899d-72a5ac50dd6d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
