using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvisibleTrickster : Template
    {
        public static readonly Guid ID = Guid.Parse("308c9552-5d5a-43eb-95a1-1542aa86cf58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invisible Trickster",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc9847f0-657d-42aa-8c41-e24ffb0c3687"), Type = TextBlockType.Text, Text = "You have learned how to become invisible and remain so. You can cast 4th-level (spell: invisibility) as a primal innate spell once per hour." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea7e9c13-31dd-4494-ab40-204150438ed0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
