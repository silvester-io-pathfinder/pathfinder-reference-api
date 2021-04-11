using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class WinterWolfElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("b28f4309-cc04-4522-8837-b653995b3028");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Winter Wolf Elixir",
                Usage = "Held in 1 hand",
                ItemBonus = 4,
                BulkId = seeder.GetBulkByName("L").Id
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Elixir";
            yield return "Consumable";
        }

        protected override IEnumerable<AlchemicalElixirDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalElixirDetailBlock { Id = Guid.Parse("7b92f530-d78e-4683-b967-9de524ac2063"), Text = "This elixir warms your core and improves your circulation. For 24 hours, you are protected from the effects of severe cold." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("f9db054b-d24c-44d4-b52e-540188a3a862"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id,
                Level = 4,
                Price = 1500,
                Benefits = "No explicit benefits are listed for the Lesser potency."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("f9db054b-d24c-44d4-b52e-540188a3a862"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Moderate").Id,
                Level = 12,
                Price = 32000,
                Benefits = "You’re also protected from extreme cold."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("c62e9b49-532a-474f-8dfe-1cd38fd4c6a5"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Greater").Id,
                Level = 16,
                Price = 140000,
                Benefits = "You’re also protected from extreme and incredible cold."
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("df8b0c80-d477-4466-9d2d-5e632c0380a3"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 550
            };
        }
    }
}
