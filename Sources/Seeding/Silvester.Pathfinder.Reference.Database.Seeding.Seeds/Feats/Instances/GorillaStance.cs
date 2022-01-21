using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GorillaStance : Template
    {
        public static readonly Guid ID = Guid.Parse("5947b273-4c30-4ae8-8f99-245d89b9a4e9");

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
            yield return new TextBlock { Id = Guid.Parse("7854bb45-3b80-472f-ab34-5014c2f8cb8a"), Type = TextBlockType.Text, Text = "You lower yourself to the ground and take an imposing, knuckle-walking stance. While in this stance, the only (action: Strikes | Strike) you can make are gorilla slam unarmed attacks. These deal 1d8 bludgeoning damage; are in the brawling group; and have the (trait: backswing), (trait: forceful), (trait: grapple), (trait: nonlethal), and (trait: unarmed) traits. While you are in Gorilla Stance, you gain a +2 circumstance bonus to Athletics checks to (action: Climb), and if you roll a success on an Athletics check to (action: Climb), you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e10d0072-afc2-4bc9-83c9-2f49218331f6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
