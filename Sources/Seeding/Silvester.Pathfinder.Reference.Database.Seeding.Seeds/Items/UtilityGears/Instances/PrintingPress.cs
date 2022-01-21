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
    public class PrintingPress : Template
    {
        public static readonly Guid ID = Guid.Parse("d9bc7ce4-c0c2-4193-84ed-83325dd4169b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Printing Press",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("02dd2208-85e9-4573-aa3d-d8bf7c65c3ef"), "The printing press is a revolutionary machine that combines movable type with a mechanical inking system and screw press, allowing for the mass production of large volumes of text. Using the press, a worker can produce up to 3,600 identical pages per day. In order to use the printing press, you must first set the type for the page you want to print. Time required to set type varies depending on the number of characters used; from 1 hour for small pages with brief text, to 8 hours for a full-sized normal page of text, though extreme examples may be outside this range. When you prepare a page for printing, you can include engraved images in addition to text. No magical properties of text are transferred in the printing process, so it cannot be used to mass-produce magical scrolls, glyphs of warding, or similar spells or magic items.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("dff010a2-2616-4cce-a30d-c1397807af3b"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("29c6da80-5189-4997-9434-4f8b0432d7c8"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4f65bc3b-c9da-4a66-a3e4-1e5cac889fb9"),
                Name = "Printing Press",
                Level = 9,
                Price = 60000,
                BulkId = Bulks.Instances.TwentyBulk.ID,
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35974c3e-259a-4275-abf2-f22d517d4ee8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 89
            };
        }
    }
}
