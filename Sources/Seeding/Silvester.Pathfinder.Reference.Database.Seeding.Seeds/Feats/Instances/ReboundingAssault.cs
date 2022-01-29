using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReboundingAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("9153a52e-199a-42c0-a2fb-5c0bf64a0356");

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
            yield return new TextBlock { Id = Guid.Parse("195c1824-a3f9-42cb-87ed-3d8322e0d6a7"), Type = TextBlockType.Text, Text = $"You hurl your melee weapon at an opponent, then fire a bullet into the weapon's hilt, making it deal additional damage and bounce back to your grasp. Make a thrown ranged Strike with the melee weapon, then a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your firearm. Both {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} use the same multiple attack penalty. If the melee weapon doesn't already have the thrown trait, it gains the {ToMarkdownLink<Models.Entities.Trait>("thrown 10 feet", Traits.Instances.Thrown.ID)} trait during a Rebounding Assault." };
            yield return new TextBlock { Id = Guid.Parse("decb8d76-1acc-433d-86d0-2a8562d2ecd7"), Type = TextBlockType.Text, Text = $"If both attacks are successful, the bolt or bullet hits the thrown melee weapon instead of your target, adding its force into one attack. Combine the damage from both {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, using the thrown weapon's damage type, and add an additional 1d6 precision damage. The impact sends the melee weapon rebounding off the target and back to your hand." };
            yield return new TextBlock { Id = Guid.Parse("15f9e433-5ac5-40b7-8ef9-e9a4d01b0410"), Type = TextBlockType.Text, Text = $"In any circumstance other than both attacks hitting, carry out the individual {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} normally. The thrown weapon doesn't rebound and remains in the target's space as normal for thrown weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53e4f9fa-6517-425f-817f-2b855591b15b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
