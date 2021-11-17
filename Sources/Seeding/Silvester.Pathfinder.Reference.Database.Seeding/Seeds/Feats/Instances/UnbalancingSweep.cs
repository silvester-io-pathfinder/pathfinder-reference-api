using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnbalancingSweep : Template
    {
        public static readonly Guid ID = Guid.Parse("ce61c1e9-4034-49b0-b3ce-14eb8dcbb7cc");

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
            yield return new TextBlock { Id = Guid.Parse("2771c06f-6ee7-4320-8857-26bb925916d1"), Type = TextBlockType.Text, Text = "You make a great sweep about yourself, knocking creatures off their feet and away from you. Choose up to three adjacent foes and choose whether to (action: Shove) or (action: Trip) all three of them. Whichever of the two options you choose, roll a separate Athletics check against each foe, performing the same action against each foe. Each attempt counts toward your multiple attack penalty, but don’t increase your penalty until you have made all the attempts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f6cec332-a77d-43d7-9f99-ede4e0f3dfce"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1bbe052-67e4-4609-a04b-ab50be150d56"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
