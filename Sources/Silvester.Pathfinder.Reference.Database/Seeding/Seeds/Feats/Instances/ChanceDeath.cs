using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChanceDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("0a3c00e7-e470-4ef1-a80c-0db9af262ac5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Chance Death",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can select this feat only at 1st level, and you can't retrain into or out of this feat.",
                Trigger = "You would die as a result of a failed saving throw or recovery check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("436b7b25-3e8b-42d0-9cf9-dfc0c5baff7f"), Type = TextBlockType.Text, Text = "Your previous life ended due to sheer poor luck, struck by lightning or choking on a fish bone. You can reroll the triggering recovery check or saving throw, but you must use the new result, even if it’s worse than the first roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82e58628-5f6d-4fa8-baf5-a9c85134ff5a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
