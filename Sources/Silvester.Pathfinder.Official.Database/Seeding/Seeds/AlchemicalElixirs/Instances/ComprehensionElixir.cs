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
    public class ComprehensionElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("787a099b-e070-4e58-b0b7-89c5e2f0aac9");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Comprehension Elixir",
                Usage = "Held in 1 hand",
                ItemBonus = 2,
                BulkId = seeder.GetBulkByName("L").Id
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Elixir";
            yield return "Consumable";
            yield return "Mental";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("99f4909b-5fd9-4602-abb9-84a2309b4879"), Text = "This bitter draft opens your mind to the potential of the written word. For the listed duration after drinking this elixir, you can understand any words you read, so long as they are written in a common language. This elixir doesn’t automatically allow you to understand codes or extremely esoteric passages—you still need to attempt a skill check to Decipher Writing." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("f6d92417-5da6-46d8-b455-adf5d1a6e6ac"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id,
                Level = 2,
                Price = 700,
                Benefits = "The duration is 1 minute.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("557a7b9c-4525-4792-a089-0cd90884bef7"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Greater").Id,
                Level = 7,
                Price = 5400,
                Benefits = "The duration is 10 minutes.",
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("e859dce4-cd01-4326-816e-c966ccc2a34b"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 547
            };
        }
    }
}
