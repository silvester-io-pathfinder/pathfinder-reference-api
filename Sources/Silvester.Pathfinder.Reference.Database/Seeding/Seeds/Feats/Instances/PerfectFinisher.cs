using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("9c985dc2-e7f3-4b84-a67b-7ded8fadc93d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Finisher",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4eab377f-4c82-4a3b-bbc4-6b9892391c97"), Type = TextBlockType.Text, Text = "You focus your panache into an impeccable assault. Make a (action: Strike), rolling the attack roll twice and using the better result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2610ae1a-2044-49f7-8ae6-9d8fc9100c56"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
