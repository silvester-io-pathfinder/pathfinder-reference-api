using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class CheetahsElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("7a89776c-ffcc-4766-8ddb-d0d6f2227c30");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Cheetah's Elixir",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
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
            yield return new AlchemicalElixirDetailBlock { Id = Guid.Parse("c3d0b8fa-4656-44c2-86ad-2247cc2326fd"), Text = "Enzymatic compounds in this elixir strengthen and excite the muscles in your legs. You gain a status bonus to your Speed for the listed duration." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("fe4a4297-984f-492d-b46c-09a59eeadd81"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id,
                Level = 1,
                Price = 300,
                Benefits = "The bonus is +5 feet, and the duration is 1 minute.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("45cdabed-781e-4476-810d-3972cd2a68c1"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Moderate").Id,
                Level = 5,
                Price = 2500,
                Benefits = "The bonus is +10 feet, and the duration is 10 minutes.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("a5799229-afdb-4118-910f-000a05eb7681"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Greater").Id,
                Level = 9,
                Price = 11000,
                Benefits = "The bonus is +10 feet, and the duration is 1 hour.",
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("35bda9da-c238-43e3-8446-b5e2ebefdae1"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 547
            };
        }
    }
}
