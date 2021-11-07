using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MoonMay : Template
    {
        public static readonly Guid ID = Guid.Parse("6a343b2c-38d7-4156-847b-58460a505977");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Moon May",
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
            yield return new TextBlock { Id = Guid.Parse("6393f123-4539-43ad-ab36-097c5412c392"), Type = TextBlockType.Text, Text = "Your mother was a moon hag, a handmaiden of Groetus, and you have a single scarlet eye and a sliver of her supernal foresight. You can cast (spell: guidance) as an occult innate cantrip. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4238be13-ed4c-4100-b2eb-429c9d124c51"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
