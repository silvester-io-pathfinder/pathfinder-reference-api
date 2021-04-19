using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class MistformElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("87e2ed9e-5358-493d-be9f-0f96150b5b7a");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Mistform Elixir",
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
            yield return "Illusion";
            yield return "Visual";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("518dfefb-b42e-457a-a7f2-df253f733f15"), Text = "A faint mist emanates from your skin, making you concealed for the listed duration. As usual, if you become concealed when your position is still obvious, you can’t use this concealment to Hide or Sneak." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("26b6036e-5be6-4998-a4cb-7e5eb4580f42"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id,
                Level = 4,
                Price = 1800,
                Benefits = "The duration is 3 rounds."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("682c3083-33ff-4b69-b25c-1a249a9d81cd"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Moderate").Id,
                Level = 6,
                Price = 5600,
                Benefits = "The duration is 1 minute."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("70eda229-1d6e-4e66-9adf-6dc941b35eb8"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Greater").Id,
                Level = 10,
                Price = 18000,
                Benefits = "The duration is 5 minutes."
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("39900b0b-1dab-41b8-93bf-4af4fa597e8b"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
