using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GorillaStance : Template
    {
        public static readonly Guid ID = Guid.Parse("c36e90a4-a148-448d-b42c-31b5bdaa5852");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gorilla Stance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19cb4805-e5fe-45f2-9f12-caabc90f4ea4"), Type = TextBlockType.Text, Text = "You lower yourself to the ground and take an imposing, knuckle-walking stance. While in this stance, the only (action: Strikes | Strike) you can make are gorilla slam unarmed attacks. These deal 1d8 bludgeoning damage; are in the brawling group; and have the (trait: backswing), (trait: forceful), (trait: grapple), (trait: nonlethal), and (trait: unarmed) traits. While you are in Gorilla Stance, you gain a +2 circumstance bonus to Athletics checks to (action: Climb), and if you roll a success on an Athletics check to (action: Climb), you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf51df89-1582-45eb-bc0e-6661a0d3e972"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
