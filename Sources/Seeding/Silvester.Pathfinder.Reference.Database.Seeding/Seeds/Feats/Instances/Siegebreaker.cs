using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Siegebreaker : Template
    {
        public static readonly Guid ID = Guid.Parse("47fa3d01-35d2-4a57-b2b0-b5433947f6a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Siegebreaker",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ca991ae-379a-4e28-9abf-9b7f6c59e81b"), Type = TextBlockType.Text, Text = "With unbelievable force, you charge and smash your weapon into a target before digging in your heels and pulling the trigger. (action: Leap) or (action: Stride), then make a (action: Strike) with the required firearm or crossbow against an adjacent target. This (action: Strike) deals an additional 3d8 bludgeoning damage and ignores 10 points of the target’s Hardness (if any), or of their shield’s Hardness if the target uses (feat: Shield Block)." };
            yield return new TextBlock { Id = Guid.Parse("d3b55cbe-54c9-47ed-bc5c-444227302067"), Type = TextBlockType.Text, Text = "After the (action: Strike), you become immobilized and position the required weapon defensively, gaining a +1 circumstance bonus to AC, or a +2 circumstance bonus if the chosen weapon has the (trait: parry) trait. Both effects last until the start of your next turn. If a force would move you while you’re immobilized in this way, it must succeed at an appropriate check against your class DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddbd72de-19cd-4a20-aaa1-40bcf512241f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
