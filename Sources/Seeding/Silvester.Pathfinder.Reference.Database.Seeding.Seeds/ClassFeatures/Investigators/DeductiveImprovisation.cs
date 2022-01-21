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
    public class DeductiveImprovisation : Template
    {
        public static readonly Guid ID = Guid.Parse("d69c37c1-4d8f-441a-98d8-1a9eded50b79");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Deductive Improvisation", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3698b6cc-c72a-4f76-af9a-710dcc9f06fe"), Type = TextBlockType.Text, Text = "You use your skills at deduction to perform whatever task is necessary to solve the case. You can attempt any check that requires you to be trained in a skill, even if you're untrained in it; you can attempt any check that requires you to have expert proficiency in a skill so long as you're trained in it; and you can attempt any check that requires you to have master proficiency in a skill as long as you have expert proficiency in it." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add modification effects..
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80d69f4c-5977-47cd-9053-3a9d59ba3646"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
