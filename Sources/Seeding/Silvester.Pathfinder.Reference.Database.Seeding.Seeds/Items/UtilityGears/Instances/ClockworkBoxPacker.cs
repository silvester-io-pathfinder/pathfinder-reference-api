using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class ClockworkBoxPacker : Template
    {
        public static readonly Guid ID = Guid.Parse("51b9cd1c-9036-445f-85e0-554f7ce7a7a3");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Clockwork Box Packer",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4825e4a8-068a-430f-a077-8e929b00c62c"), "This handy clockwork device is too expensive for most warehouses and shipping docks to make use of it, but some nobles have purchased the item for their staff as a status symbol, and merchants who are in the shipping trade can afford to slowly reap the benefits of its usage. It takes 1 minute to wind a clockwork box packer; after which, it can function for up to 1 hour.");
            builder.Text(Guid.Parse("6f8f26f8-4eff-47ee-a225-d79181c68aea"), "You can indicate how high you want the clockwork box packer to stack boxes and what the packing storage dimensions are. Once packing instructions have been input, you can load a crate onto the clockwork box packer, and it begins its task. Once the box is stacked, the clockwork box packer closes the box, if necessary, then ties a ribbon or cord around it from a supply loaded into the clockwork box packer in advance. Once the package is secure, the clockwork box packer stacks it and then swivels back into position, ready to accept another box. In this way, the clockwork device can finish within minutes a packing job that might take humanoid workers an hour.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("492adc7b-75c1-42dd-86bf-e818a2eb9121"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("42781ef8-f1e1-42cd-be05-31ecb80e5e0a"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("d6a0ceda-ede9-4a3d-9005-d8f28271fdde"),
                Name = "Clockwork Box Packer",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.FourBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d697fb59-d0a9-4110-9c2d-f22d4c1fbf33"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 85
            };
        }
    }
}
