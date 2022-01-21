using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class MechanicalTorch : Template
    {
        public static readonly Guid ID = Guid.Parse("fb46d5d3-19ef-4a4a-84e5-d98fbfe44764");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Mechanical Torch",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("52c78c30-8f70-400e-9730-d8ac7384c275"), "Powered by electricity, you can turn a mechanical torch on and off by toggling a lever on the torch with an Interact action. When active, the torch sheds bright light in either a 20-foot radius (and dim light to the next 40 feet) or a 40-foot cone (and dim light to the next 40 feet). Changing this area requires a single Interact action to flip a switch. The torch carries sufficient charge to operate for ten minutes. You can recharge the torch in 1 minute via an integrated crank-charging mechanism, turning the clockwork gears and generating sparks to power the torch, though doing so requires two hands.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("48d640ff-ff8b-47ad-9f9e-baf7d989aa8d"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ba0c152f-a266-4edd-94aa-42c5bcde4b18"),
                Name = "Mechanical Torch",
                Usage = "Held in 1 hand.",
                Level = 1,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9a7d09a-ebea-4521-a480-58127fae5e9e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 88
            };
        }
    }
}
