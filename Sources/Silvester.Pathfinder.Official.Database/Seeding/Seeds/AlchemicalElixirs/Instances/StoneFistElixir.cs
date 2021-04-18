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
    public class StoneFistElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("58f3f7fd-4244-4a42-b684-d995220d4ade");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Stone Fist Elixir",
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
            yield return "Morph";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdcd2d5b-5901-4d52-81b9-7645684928c0"), Text = "Your fists become hard as stone. For 1 hour, your fists deal 1d6 bludgeoning damage and lose the nonlethal trait." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("e393357d-29cf-42ba-bbab-01f227faebfb"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Unclassified").Id,
                Level = 4,
                Price = 1300,
                Benefits = "The Stone Fist Elixir only exists as a single unclassified potency."
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("87156a04-1bcc-4ec5-a7b6-ad44e0189935"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 550
            };
        }
    }
}
