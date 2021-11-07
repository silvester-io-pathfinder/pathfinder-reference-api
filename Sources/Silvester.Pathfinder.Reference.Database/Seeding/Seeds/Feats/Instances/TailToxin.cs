using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TailToxin : Template
    {
        public static readonly Guid ID = Guid.Parse("415a63f2-5da6-4dd4-b858-6a55280b6deb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tail Toxin",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19c55313-b7d2-455a-a3b7-2bd3ccbaf53c"), Type = TextBlockType.Text, Text = "You apply your tail&#39;s venom to a piercing or slashing weapon. If your next (action: Strike) with that weapon before the end of your next turn hits and deals damage, you deal persistent poison damage equal to your level to the target." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("529a9d29-75ac-40f7-9912-9660bf2e3a0f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
