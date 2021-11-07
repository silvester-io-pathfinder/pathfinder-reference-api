using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Swift : Template
    {
        public static readonly Guid ID = Guid.Parse("9b278118-27ad-42c9-9cec-f96551334088");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swift",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "The Speed increase from this feat isn't cumulative with any Speed increase from your ancestry feats (such as (feat: Nimble Elf)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d9efa7e-13cf-496f-842e-e49b5bcdd2f1"), Type = TextBlockType.Text, Text = "You move with the wind always at your back. Your Speed increases by 5 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c243dbc-c0a3-4d41-bdd5-2e60e74edb8b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
