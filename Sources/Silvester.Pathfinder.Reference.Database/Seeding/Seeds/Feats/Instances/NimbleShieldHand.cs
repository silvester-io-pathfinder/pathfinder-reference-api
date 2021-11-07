using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NimbleShieldHand : Template
    {
        public static readonly Guid ID = Guid.Parse("05c3bc38-f6ec-46cc-a633-3e4435b80e18");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nimble Shield Hand",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ded99fc-6b29-4dbe-8b2c-a3791043e717"), Type = TextBlockType.Text, Text = "You are so used to wielding a shield that you can do so even while using the hand that’s holding it for other purposes. The hand you use to wield a shield counts as a free hand for the purposes of the (action: Interact) action. You can also hold another object in this hand (but you still can’t use it to wield a weapon). This benefit doesn’t apply to (item: tower shields | Tower Shield), which are still too cumbersome." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5a26c3b8-e35d-486f-a2c5-5942ecaf5e3e"), Feats.Instances.BastionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bdf4f4d-e1b4-41a8-b1d7-c09c7360a2e3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
