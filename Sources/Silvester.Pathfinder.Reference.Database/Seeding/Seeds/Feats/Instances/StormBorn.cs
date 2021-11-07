using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StormBorn : Template
    {
        public static readonly Guid ID = Guid.Parse("ac681a31-ea3d-430f-97b9-568594f359b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Storm Born",
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
            yield return new TextBlock { Id = Guid.Parse("a81dad86-e9ff-4ec9-be80-666b9e381aea"), Type = TextBlockType.Text, Text = "You are at home out in the elements, reveling in the power of nature unleashed. You do not take circumstance penalties to ranged spell attacks or Perception checks caused by weather, and your targeted spells don’t require a flat check to succeed against a target concealed by weather (such as fog)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("d9c28db3-f6ca-4cc7-a140-f02742d80310"), DruidicOrders.Instances.Storm.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59e0cf3d-4a0e-4485-99c3-48e49ff016bf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
