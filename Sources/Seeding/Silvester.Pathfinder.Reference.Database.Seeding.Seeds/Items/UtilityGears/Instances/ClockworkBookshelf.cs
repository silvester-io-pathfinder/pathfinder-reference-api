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
    public class ClockworkBookshelf : Template
    {
        public static readonly Guid ID = Guid.Parse("8effea5d-6d5b-46cd-a98e-b324f98da787");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Clockwork Bookshelf",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4ca4f91b-7db1-4025-9e7d-07c7a680fbda"), "This device was originally created by an inventor who had way more books they wanted to access than available wall space to store them. Each of the bookshelf�s six levels is actually loaded with a pair of shelves instead of a single shelf. A simple switch on the side of the bookshelf flips the corresponding shelf to the other side, revealing any books stored in the paired shelf. While this makes the clockwork bookshelf a little deeper than a normal bookshelf, in order to fit both shelves, it effectively allows you to store twice as many books using the same amount of wall space. Those who wish to keep volumes hidden from visitors (or perhaps stow a weapon or potion within a false book) often load the hidden shelf first, then switch to the second shelf lined with more respectable volumes.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("266a9dec-b21e-41c1-8c1e-2e63bbe1b9dd"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f24e0a53-6bd2-456f-91ef-918d90418caa"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("7c6908e4-9c07-495a-8814-6e5a141ce03c"),
                Name = "Clockwork Bookshelf",
                Level = 1,
                Price = 1500,
                BulkId = Bulks.Instances.FourBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5dfb25cc-ca4b-49a0-991f-8541e2e93311"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 85
            };
        }
    }
}
