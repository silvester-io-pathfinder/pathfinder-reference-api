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
    public class Ignitor : Template
    {
        public static readonly Guid ID = Guid.Parse("a38ab921-f282-40d7-80bb-9be22e5c22ac");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Ignitor",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("66722c6e-fa1b-4836-8a3f-cc71d083019a"), "An ignitor uses interlocking clockwork to create a small spark in order to ignite flammable materials. While holding the ignitor, you can Interact with it to ignite a flammable object within reach.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9d3357c0-c5ab-4572-ba9d-996296ce6f30"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a998f4e9-a782-4b2f-9fcc-c7c6893d6f84"),
                Name = "Ignitor",
                Usage = "Held in 1 hand.",
                Level = 1,
                Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("286d57d5-5576-4ba0-b8e2-d0e5a9e9c8a8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 88
            };
        }
    }
}
