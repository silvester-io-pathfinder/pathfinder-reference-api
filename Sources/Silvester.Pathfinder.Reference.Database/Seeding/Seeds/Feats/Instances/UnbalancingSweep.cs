using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnbalancingSweep : Template
    {
        public static readonly Guid ID = Guid.Parse("cf4e3c54-fd59-413c-84a0-9364643cde85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unbalancing Sweep",
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
            yield return new TextBlock { Id = Guid.Parse("ae3fb15d-1fb9-4cf6-94fc-1ec2d0d652ee"), Type = TextBlockType.Text, Text = "You make a great sweep about yourself, knocking creatures off their feet and away from you. Choose up to three adjacent foes and choose whether to (action: Shove) or (action: Trip) all three of them. Whichever of the two options you choose, roll a separate Athletics check against each foe, performing the same action against each foe. Each attempt counts toward your multiple attack penalty, but don’t increase your penalty until you have made all the attempts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("33e6ddb0-395a-4751-bced-49b6da8a295b"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e308db3-54b2-48a1-bade-e4882f59065b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
