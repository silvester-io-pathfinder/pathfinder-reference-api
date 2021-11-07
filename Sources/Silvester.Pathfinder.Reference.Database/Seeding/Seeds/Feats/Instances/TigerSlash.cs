using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TigerSlash : Template
    {
        public static readonly Guid ID = Guid.Parse("70967221-4061-4ef7-9578-a18959d91eea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tiger Slash",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6f0a89da-9c58-4ed3-a83a-55ffec058e5f"), Type = TextBlockType.Text, Text = "You make a fierce swipe with both hands. Make a tiger claw (action: Strike). It deals two extra weapon damage dice (three extra dice if you’re 14th level or higher), and you can push the target 5 feet away as if you had successfully (action: Shoved | Shove) them. If the attack is a critical success and deals damage, add your Strength modifier to the persistent bleed damage from your tiger claw." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cb3da654-9064-419e-926f-1fcdf93f7f14"), Feats.Instances.TigerStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8014bd8-8a88-4176-b876-ff54bfa8f741"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
