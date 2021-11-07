using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnbalancingBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("0fba1cce-4e16-4b05-a558-c0c359773fa3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unbalancing Blow",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47c7ae36-c0a0-4dfa-a3c5-3a04adf1ca86"), Type = TextBlockType.Text, Text = "Interweaving your most powerful attacks in a graceful flow, you temporarily unbalance your foes. Whenever your (action: Strike) is a critical hit and deals damage, the target is flat-footed against your attacks until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("cafb74b1-e541-4336-bf3e-2444292bef74"), Rackets.Instances.Thief.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6cd54e0a-325f-40e8-b093-f50657eaa7e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
