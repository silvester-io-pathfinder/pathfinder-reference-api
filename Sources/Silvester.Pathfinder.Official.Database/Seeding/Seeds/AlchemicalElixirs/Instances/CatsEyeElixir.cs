using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class CatsEyeElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("9273e6ad-3f3c-4e7d-9b9c-4a8faec61145");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Cat's Eye Elixir",
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
            yield return "";
        }

        protected override IEnumerable<AlchemicalElixirDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalElixirDetailBlock { Id = Guid.Parse("70db1dfe-abca-4416-b8ba-8825604c77d9"), Text = "After you consume this elixir, your vision sharpens and you become sensitive to even the most minute movements. For the next minute, you reduce the flat check to target hidden creatures to 5, and you don’t need to attempt a flat check to target concealed creatures. These benefits apply only against creatures within 30 feet of you." };
        }


        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("39b6c273-ce0b-46a5-ab96-6603a5d79ed4"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id,
                Level = 1,
                Price = 700,
                Benefits = "The Cat's Eye Elixir only exists in a single form, so no other potencies exist."
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6773943d-c2fc-4e8a-ba93-e1d4d9766757"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 547
            };
        }
    }
}
