using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RangedReprisal : Template
    {
        public static readonly Guid ID = Guid.Parse("0e85a79b-c702-47d9-ae70-becec503357b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ranged Reprisal",
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
            yield return new TextBlock { Id = Guid.Parse("282541c0-fd75-4dbf-a8ba-400ad8f8cf7b"), Type = TextBlockType.Text, Text = "You can use (feat: Retributive Strike) with a ranged weapon. In addition, if the foe that triggered your reaction is within 5 feet of your reach but not in your reach, as part of your reaction you can (action: Step) to put the foe in your reach before making a melee (feat: Retributive Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("be4b88b5-2cf2-4807-ad6f-cf7fdc6e8c8b"), Causes.Instances.Paladin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73509c43-ff54-418b-b293-18c9cf5ceacb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
