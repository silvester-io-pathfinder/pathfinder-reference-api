using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProximityAlert : Template
    {
        public static readonly Guid ID = Guid.Parse("526f8e01-f776-48be-af09-0313f3a2408e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Proximity Alert",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("88d7c929-8d5b-4461-a0e5-e789efcd606c"), Type = TextBlockType.Text, Text = "You’re unnaturally in tune with your surroundings and react instinctively to danger. You gain a +2 circumstance bonus to Perception checks made as initiative rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c48edcf8-cd8b-4b2e-87b2-6152a4462d30"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
