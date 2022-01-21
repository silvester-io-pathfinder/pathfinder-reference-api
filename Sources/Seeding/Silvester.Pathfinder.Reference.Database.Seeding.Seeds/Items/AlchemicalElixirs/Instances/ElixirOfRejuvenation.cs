using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalElixirs.Instances
{
    public class ElixirOfRejuvenation : Template
    {
        public static readonly Guid ID = Guid.Parse("c9715348-c813-422b-af5b-e2c9a11884a9");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Elixir of Rejuvenation",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5b3a9903-a51c-4a10-b932-ee51026807ff"), "The elixir of rejuvenation restores a creature to full health and eradicates toxins affecting it. When you drink this elixir, you're restored to your maximum Hit Points, and all afflictions of 20th level or lower affecting you are removed."); ;
            builder.Text(Guid.Parse("1bc9c603-c18b-4898-add5-8e6533dbbeb0"), "You can instead administer this elixir to a creature that has been dead for a week or less. When you do, that creature is instantly brought back to life with 1 Hit Point and no spell slots, Focus Points, or other daily resources."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("8f2ff716-0305-4642-875f-9325f583b4a8"),
                Name = "Elixir of Rejuvenation",
                CraftingRequirements = "Philosopher's Stone, True Elixir of Life",
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
                Level = 20,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("12c6564c-e9a5-4edd-8939-ed8a41918f8e"), "The Elixir of Rejuvenation only exists as a single unclassified potency.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("30d67580-9411-4e9e-9dc2-2cb35fd4189f"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("a190246d-1708-4579-a07d-77d8259df044"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("4f88f015-6eda-4457-a4c7-db44b9f09417"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("871e713d-3cbc-4eff-9885-a375e03dcef2"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b82b237a-93c2-4268-998d-f367fd9a48c3"), Traits.Instances.Healing.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b04b283-38a7-4557-ad92-2128845aab30"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
