using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestorsTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("2d76b208-1817-4390-9d3f-edc53239f765");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestor's Transformation",
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
            yield return new TextBlock { Id = Guid.Parse("2de82cec-ca3f-4619-b7b9-da6e23b0efb1"), Type = TextBlockType.Text, Text = "You can commune with ancestor spirits to assume the form of an enormous primeval strix. You can cast 5th-level (spell: aerial form) as a primal innate spell once per day, but you take the form of a primeval strix, using the statistics for a bird form." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c66133e1-1a04-4f10-92e0-52a8fe3dfb0a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
