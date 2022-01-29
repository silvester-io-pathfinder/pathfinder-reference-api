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
    public class Timepiece : Template
    {
        public static readonly Guid ID = Guid.Parse("6acf04a4-5d96-4d2a-bbb9-4e2e1cb7886f");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Timepiece",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("de45bc0b-1f2f-4d7d-b79f-8db52d8946eb"), "Clockwork timepieces come in a variety of sizes and aesthetic styles, but they're all designed to display the accurate time of day down to the second.");
            builder.Text(Guid.Parse("d168d36b-6ea5-407d-b071-c6ed3ae0f8d4"), "Clockwork timepieces have a 24-hour activation cycle, after which they must wound in a process that takes 1 minute to complete.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b472f358-dd4d-46cf-aa33-555e513b4da4"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8d514cbc-710c-44cb-aa78-6d6f8a05688f"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("895485e3-507e-409b-be32-f0e944685abc"),
                Name = "Desktop Clock",
                Level = 1,
                Price = 1000,
                BulkId = Bulks.Instances.ThreeBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6c7b911f-4d63-4739-b6ee-7fe07c2bf068"), "Desktop clocks have been designed to be small enough to only take up a quarter of a typical writing desk's surface area, but they're still too bulky and heavy to be lugged around casually.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("8b707f3d-83f2-4add-98e2-a296a57310c7"),
                Name = "Grand Clock",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.SixteenBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f2456ab1-b667-4591-9a49-d59e43718108"), "These towering, ten-foot-tall clocks have been painstakingly handcrafted by skilled artisans and feature loud chimes that can be heard hourly throughout a manor. Owners of grand clocks usually tend to display them prominently in a study, lounge area, or foyer.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c1ac563-eb84-40b5-90ad-65a9fc3e2f67"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 89
            };
        }
    }
}
