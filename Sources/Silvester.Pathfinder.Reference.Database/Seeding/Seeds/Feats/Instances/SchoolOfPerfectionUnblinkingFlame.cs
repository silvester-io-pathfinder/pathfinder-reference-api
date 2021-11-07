using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolOfPerfectionUnblinkingFlame : Template
    {
        public static readonly Guid ID = Guid.Parse("e2a056e7-04be-40b5-b1a4-757c4454c9d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "School of Perfection - Unblinking Flame",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("49ea15d6-e0aa-470f-b677-339034050a4f"), Type = TextBlockType.Text, Text = "You gain the (spell: unblinking flame revelation) ki spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bd4b63f-a156-4317-b991-c0c3f14206db"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
