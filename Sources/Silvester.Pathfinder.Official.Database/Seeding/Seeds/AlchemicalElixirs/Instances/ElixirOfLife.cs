using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class ElixirOfLife : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("479d0265-a1a4-41f3-afd0-8ad618bdb7a6");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Elixir of Life",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Healing.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("150dac7f-5e0c-461a-91ea-1d6b6cb5fda9"), Text = "Elixirs of life accelerate a living creature’s natural healing processes and immune system. Upon drinking this elixir, you regain the listed number of Hit Points and gain an item bonus to saving throws against diseases and poisons for 10 minutes." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("dacf4b83-8fb8-491a-b488-f58b96eab7d5"),
                PotionPotencyId = Potencies.Instances.Minor.ID,
                Level = 1,
                Price = 300,
                Benefits = "The elixir restores 1d6 Hit Points, and the bonus is +1."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("2baf4a62-f1e3-4960-ac8f-a60954b4c9e2"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 5,
                Price = 3000,
                Benefits = "The elixir restores 3d6+6 Hit Points and the bonus is +1."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("a5bc4dfd-5e13-4005-b061-338b4c23826e"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 9,
                Price = 15000,
                Benefits = "The elixir restores 5d6+12 Hit Points, and the bonus is +2."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("d6f46c03-c140-4c4c-8343-f1f4d0ad9b89"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 13,
                Price = 60000,
                Benefits = "The elixir restores 7d6+18 Hit Points, and the bonus is +2."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("56e641d4-48b2-4487-a96e-5e7d301affa1"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 15,
                Price = 130000,
                Benefits = "The elixir restores 8d6+21 Hit Points, and the bonus is +3."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("6b62bddc-b7e5-49cf-8379-67c972f83dd4"),
                PotionPotencyId = Potencies.Instances.True.ID,
                Level = 19,
                Price = 800000,
                Benefits = "The elixir restores 10d6+27 Hit Points, and the bonus is +4."
            };

        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbefcb2c-8c92-4afa-9bfe-14df0480ea74"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
