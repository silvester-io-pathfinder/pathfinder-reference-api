using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class SalamanderElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("edf0d3e8-4400-4feb-8326-7d98976ebae7");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Salamander Elixir",
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

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5afe368-8abd-4cc4-b15a-fe449c96daac"), Text = "This elixir is made from salamander scales to withstand fire. For 24 hours, you are protected from the effects of severe heat." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("56b36a36-b64e-4971-83e3-0731620051d1"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id,
                Level = 4,
                Price = 1500,
                Benefits = "No explicit benefits are listed for the Lesser potency."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("f140633a-a10d-4792-a020-e8ac3d207dff"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Moderate").Id,
                Level = 12,
                Price = 32000,
                Benefits = "You’re also protected from extreme heat."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("8d9cceea-4f0e-4059-a024-b7873621fca6"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Greater").Id,
                Level = 16,
                Price = 140000,
                Benefits = "You’re also protected from extreme and incredible heat."
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba706507-3628-4a2c-815b-cdb54e373a88"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 549
            };
        }
    }
}
