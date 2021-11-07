using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReboundingAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("cf7cf2ad-b5b4-4523-864d-46c1ebfec227");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rebounding Assault",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4027cb75-c50c-4618-9fd0-971c48db5c70"), Type = TextBlockType.Text, Text = "You hurl your melee weapon at an opponent, then fire a bullet into the weapon’s hilt, making it deal additional damage and bounce back to your grasp. Make a thrown ranged Strike with the melee weapon, then a ranged (action: Strike) with your firearm. Both (action: Strikes|Strike) use the same multiple attack penalty. If the melee weapon doesn’t already have the thrown trait, it gains the (trait: thrown 10 feet|thrown 10 ft) trait during a Rebounding Assault." };
            yield return new TextBlock { Id = Guid.Parse("59f7503c-5158-41eb-93d5-810ef99c96a6"), Type = TextBlockType.Text, Text = "If both attacks are successful, the bolt or bullet hits the thrown melee weapon instead of your target, adding its force into one attack. Combine the damage from both (action: Strikes|Strike), using the thrown weapon’s damage type, and add an additional 1d6 precision damage. The impact sends the melee weapon rebounding off the target and back to your hand." };
            yield return new TextBlock { Id = Guid.Parse("e0ddcb4f-55cc-44ee-b250-446a7408e6cf"), Type = TextBlockType.Text, Text = "In any circumstance other than both attacks hitting, carry out the individual (action: Strikes|Strike) normally. The thrown weapon doesn’t rebound and remains in the target’s space as normal for thrown weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5f8b568-9830-4a38-bccb-fd881c903814"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
