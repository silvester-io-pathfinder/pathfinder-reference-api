using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeatWave : Template
    {
        public static readonly Guid ID = Guid.Parse("53871824-1f0d-40c1-895b-2ee6ce9fb7c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heat Wave",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An effect would deal fire damage to you, even if you resist all the damage.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("56fbcb6c-663e-4262-b841-7a34b87deefe"), Type = TextBlockType.Text, Text = "You harness the oncoming flames and twist them into a screen of heat and smoke, granting you concealment until the beginning of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1407881-b57d-4c97-bd67-b58429aab4b5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
