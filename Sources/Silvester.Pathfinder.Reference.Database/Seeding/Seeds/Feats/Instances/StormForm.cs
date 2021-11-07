using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StormForm : Template
    {
        public static readonly Guid ID = Guid.Parse("820783bf-12e9-48b2-9f7b-1904e633c1c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Storm Form",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89e89306-d658-44e6-9ec0-049868c58a0a"), Type = TextBlockType.Text, Text = "You can transform into an elemental. Once per day, you can cast (spell: elemental form) as a 7th-level primal innate spell, but you can only choose the air elemental form." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f720afb4-f4d1-48da-a584-e5e351022190"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
