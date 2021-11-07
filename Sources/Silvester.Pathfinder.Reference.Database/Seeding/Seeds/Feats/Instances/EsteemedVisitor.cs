using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsteemedVisitor : Template
    {
        public static readonly Guid ID = Guid.Parse("682db0a0-2eec-4839-8c86-00fe42489201");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esteemed Visitor",
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
            yield return new TextBlock { Id = Guid.Parse("c80e0eca-c289-438f-9d64-111166219dce"), Type = TextBlockType.Text, Text = "Your polite manners and natural ability to comfort others make it easy for you to break down cultural barriers and earn strangers’ trust. While you are in a settlement, when you roll a critical failure on a Diplomacy check to (Action: Gather Information) or (Action: Make an Impression), you get a failure instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67f8a390-5840-4a0a-901a-7b64d14d78e0"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
