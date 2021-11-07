using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflectiveRippleStance : Template
    {
        public static readonly Guid ID = Guid.Parse("45def6a5-9594-4b32-9201-3c3371862ed6");

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
            yield return new TextBlock { Id = Guid.Parse("5d79a218-37a9-4698-b7d3-195327602dd9"), Type = TextBlockType.Text, Text = "You enter a stance of fluid grace as small amounts of water flow with your movements and attacks. You can make flowing wave attacks that deal 1d6 bludgeoning damage. They are in the brawling group and have the (trait: agile), (trait: disarm), (trait: finesse), (trait: nonlethal), (trait: trip), (trait: unarmed), and (trait: water) traits." };
            yield return new TextBlock { Id = Guid.Parse("599ecb01-7ac1-4f74-9ded-e77b9aeae9ac"), Type = TextBlockType.Text, Text = "While in Reflective Ripple Stance, you gain a +1 circumstance bonus to Athletics checks to (action: Disarm), (action: Swim), or (action: Trip), and you gain a +2 circumstance bonus to your Reflex DC to avoid being (action: Disarmed | Disarm) and (action: Tripped | Trip)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2f2162c-754a-42ef-b76b-de9180a86b00"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
