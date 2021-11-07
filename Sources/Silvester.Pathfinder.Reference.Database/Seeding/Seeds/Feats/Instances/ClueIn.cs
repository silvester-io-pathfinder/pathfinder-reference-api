using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClueIn : Template
    {
        public static readonly Guid ID = Guid.Parse("bc621a0c-f991-48e8-9d82-c1c938893c59");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clue In",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Another creature attempts a check to investigate a lead you're pursuing.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed9e6741-f6be-4a83-895b-147bb43ee56b"), Type = TextBlockType.Text, Text = "You share information with the triggering creature. They gain a circumstance bonus to their check equal to your circumstance bonus to checks investigating your subject from (feat: Pursue a Lead). The GM can add any relevant traits to this reaction depending on the situation, such as (trait: auditory) and (trait: linguistic) if you&#39;re conveying information verbally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40808663-8333-4d58-8b6d-181556cdc2ab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
