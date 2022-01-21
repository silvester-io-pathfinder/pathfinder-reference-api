using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflectiveRippleStance : Template
    {
        public static readonly Guid ID = Guid.Parse("fa48a6d0-d41c-4ca6-9315-5171a4c352bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reflective Ripple Stance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat gains your choice of either the divine or occult trait, matching your ki spell tradition if possible.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38592b0a-fdf2-470b-b279-d4f87973d411"), Type = TextBlockType.Text, Text = "You enter a stance of fluid grace as small amounts of water flow with your movements and attacks. You can make flowing wave attacks that deal 1d6 bludgeoning damage. They are in the brawling group and have the (trait: agile), (trait: disarm), (trait: finesse), (trait: nonlethal), (trait: trip), (trait: unarmed), and (trait: water) traits." };
            yield return new TextBlock { Id = Guid.Parse("816d6f42-6ab4-4f19-9990-9dc5a84e2087"), Type = TextBlockType.Text, Text = "While in Reflective Ripple Stance, you gain a +1 circumstance bonus to Athletics checks to (action: Disarm), (action: Swim), or (action: Trip), and you gain a +2 circumstance bonus to your Reflex DC to avoid being (action: Disarmed | Disarm) and (action: Tripped | Trip)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f51c972f-f60b-4c9a-aa0a-62fb37dae640"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
