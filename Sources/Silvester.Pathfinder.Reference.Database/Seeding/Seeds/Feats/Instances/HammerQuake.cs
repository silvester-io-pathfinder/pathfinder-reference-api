using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HammerQuake : Template
    {
        public static readonly Guid ID = Guid.Parse("77f7fca1-f465-4eb1-b53c-5c73cb3b09ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hammer Quake",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44f87e83-7f87-474e-8ffc-4a098f100c05"), Type = TextBlockType.Text, Text = "You smash the ground with your weapon, knocking nearby creatures to the ground. Choose a square within your reach, including your own space. If there’s a foe in the chosen square, (action: Strike) that foe with the required weapon. Then attempt to (action: Trip) every foe in the chosen square plus each square adjacent to that square, ignoring (action: Trip)’s requirement that you have a hand free. This counts as three attacks toward your multiple attack penalty, but the penalty doesn’t increase until after you’ve made the (action: Strike), if any, and all the (action: Trip) attempts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("265e3383-82ac-4e71-a33e-8b457e0956c9"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("731e67dc-cf48-403d-b75b-a8e63b497367"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
