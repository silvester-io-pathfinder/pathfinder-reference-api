using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardensGuidance : Template
    {
        public static readonly Guid ID = Guid.Parse("4b64e481-996e-417f-99b4-549a64e95d94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warden's Guidance",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("809f73fb-34ca-4ddb-b3c8-baa0c2db4035"), Type = TextBlockType.Text, Text = "You can convey your prey’s location to your allies, no matter how well hidden it is. As long as your hunted prey is observed by you, all your allies who roll failures and critical failures when (action: Seeking | Seek) it get a success instead. Your allies need to be able to see or hear you to gain this benefit. You have to be able to call out or use gestures for your allies to get this benefit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74a3d02f-84ad-4548-bf4b-4ac6fd67b8f6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
