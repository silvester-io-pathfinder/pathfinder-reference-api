using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class CognitiveMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("4ef08665-b07b-4ced-8876-ef6a15229e17");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Cognitive Mutagen",
                Usage = "Held in 1 hand",
                Benefit = "You gain an item bonus to Arcana, Crafting, Lore, Occultism, and Society checks and all checks to Recall Knowledge. Your critical failures on Recall Knowledge checks become failures instead.",
                Drawback = "You take a –2 penalty to weapon and unarmed attack rolls, Athletics checks, and Acrobatics checks. You can carry 2 less Bulk than normal before becoming encumbered, and the maximum Bulk you can carry is reduced by 4.",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Mutagen.ID;
            yield return Traits.Instances.Polymorph.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0308f62-e9c4-49b4-ab1e-864a77807cd9"), Text = "Your mind becomes clear and cognition flows freely, but physical matters seem ephemeral." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("6a806118-bb1b-4a48-9c61-25cdfb30a144"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 400,
                Benefits = "The bonus is +1, and the duration is 1 minute.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("05a6d03b-b652-4c46-bad5-5ed99753462a"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 3,
                Price = 1200,
                Benefits = "The bonus is +2, and the duration is 10 minutes.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("f34b854e-2b01-426c-8fcc-17a23d7fcd4e"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 11,
                Price = 30000,
                Benefits = "The bonus is +3, and the duration is 1 hour. You become trained in one Intelligence-based skill, chosen at creation.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("543ebd11-59d5-4174-b8f8-8710b5b4a336"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 17,
                Price = 300000,
                Benefits = "The bonus is +4, and the duration is 1 hour. You become trained in one skill, chosen at creation.",
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfbada3b-aff5-4d11-bdae-51982a4d79a3"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
