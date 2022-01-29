using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Swarmsuit : Template
    {
        public static readonly Guid ID = Guid.Parse("f546cf73-375c-4637-9982-eeedd0f7abdd");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Swarmsuit",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0ff786ad-68bb-4141-8eab-ffdaaf64996d"), "These thick, overlapping layers of clothing are coupled with a matching hat, outfitted with mesh netting around its wide brim to keep you safe from insects. You gain resistance 3 to physical damage from swarms. Explorer's clothing altered in this way has a Dexterity cap of +2, check penalty of -1, and Speed penalty of -5 feet regardless of your Strength.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("035135a3-9abf-4500-a886-d723a1c058d0"),
                Name = "Swarmsuit",
                Usage = "Attached to explorer's clothing.",
                Level = 1,
                Price = 2000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
            
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c5fb8117-5a86-480c-9667-4fb9ac53635c"),
                Name = "Swarmsuit (Impenetrable)",
                Usage = "Attached to explorer's clothing.",
                Level = 8,
                Price = 42000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5e489e78-0980-4974-bf91-15b86a3a9de9"), "An impenetrable swarmsuit is made of expensive, finely crafted mesh designed to completely prevent swarms from getting inside. You gain resistance 10 to physical damage from swarms while wearing an impenetrable swarmsuit, rather than 3.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76c6ad65-6c39-45e7-936b-43fd30ffc66b"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 93
            };
        }
    }
}
