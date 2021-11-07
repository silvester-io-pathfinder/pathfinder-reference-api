using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PackTactics : Template
    {
        public static readonly Guid ID = Guid.Parse("5714698e-0582-4d8a-b38c-e345f25fb016");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pack Tactics",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee6e1baf-bd4f-464a-92df-3ee8d62a63a8"), Type = TextBlockType.Text, Text = "You have mastered how to hunt with your pack. If an enemy is within reach of you and at least two of your allies, that enemy is flat-footed against you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74dffc1c-72d3-441f-9d84-b468abfa44cb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
