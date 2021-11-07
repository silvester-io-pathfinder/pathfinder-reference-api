using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RallyingCry : Template
    {
        public static readonly Guid ID = Guid.Parse("5d47c47a-38c8-47c0-84e4-1d3f932ae260");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rallying Cry",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c91064e-5eb5-476c-8ef1-a91e18a10e7e"), Type = TextBlockType.Text, Text = "You call out to your allies and push them to give their all in combat. All allies within 30 feet that can hear you gain a number of temporary Hit Points equal to your level. In addition, these allies become quickened for 1 minute but can only use the extra action to (action: Step), (action: Stride), or (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b64f87c6-769d-4255-8e92-0fe1baa66875"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
