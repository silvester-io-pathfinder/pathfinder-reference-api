using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class WinterWolfElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("b28f4309-cc04-4522-8837-b653995b3028");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Winter Wolf Elixir",
                Usage = "Held in 1 hand",
                ItemBonus = 4,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b92f530-d78e-4683-b967-9de524ac2063"), Text = "This elixir warms your core and improves your circulation. For 24 hours, you are protected from the effects of severe cold." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("f9db054b-d24c-44d4-b52e-540188a3a862"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 4,
                Price = 1500,
                Benefits = "No explicit benefits are listed for the Lesser potency."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("1d957ae5-0642-40d9-8f2d-8d8496975a6d"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 12,
                Price = 32000,
                Benefits = "You’re also protected from extreme cold."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("c62e9b49-532a-474f-8dfe-1cd38fd4c6a5"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 16,
                Price = 140000,
                Benefits = "You’re also protected from extreme and incredible cold."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df8b0c80-d477-4466-9d2d-5e632c0380a3"),
                SourceId = CoreRulebook.ID,
                Page = 550
            };
        }
    }
}
