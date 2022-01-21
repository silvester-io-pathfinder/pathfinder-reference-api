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
    public class ExtendablePincer : Template
    {
        public static readonly Guid ID = Guid.Parse("280c546c-9154-424b-8d48-706c9a21c6ed");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Extendable Pincer",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fd7300a6-efef-4c42-9566-0ca21a147b7f"), "This extendable rod features a pincer on one end and clamped handle on the other. By squeezing the handle, the pincer opens or closes. As an Interact action, you can extend or retract the rod by 5 feet to one of three settings, allowing you to Interact to pick up an object with the pincer either within your own space, in an adjacent space, or exactly 10 feet away.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3c083d43-4d6f-4c94-8c92-8288b7888d03"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("3d50c82e-992f-4998-9f8b-9b93255a7c80"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a403e4d3-77bd-4b55-b56a-66581d79d53d"),
                Name = "Extendable Pincer",
                Usage = "Held in 2 hands.",
                Level = 0,
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID
            };

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eca8ee30-9a4b-4ac8-91d8-2622af8be542"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 87
            };
        }
    }
}
