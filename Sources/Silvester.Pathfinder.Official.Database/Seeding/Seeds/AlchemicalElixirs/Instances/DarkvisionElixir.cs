using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class DarkvisionElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("82b662fa-09dc-4cc6-a7e1-13085af44f63");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Darkvision Elixir",
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
        }

        protected override IEnumerable<AlchemicalElixirDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalElixirDetailBlock { Id = Guid.Parse("47860fc7-facb-4704-b219-ff432eb33b73"), Text = "After you drink this elixir, your sight becomes sharper in darkness.You gain darkvision for the listed duration." };
        }


        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("83e0b9b4-2eb9-4424-a262-d2deb9180d59"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id,
                Level = 2,
                Price = 600,
                Benefits = "The duration is 10 minutes.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("f2649e17-28ff-4859-8121-3f4ad7a0770d"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Moderate").Id,
                Level = 4,
                Price = 1100,
                Benefits = "The duration is 1 hour.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("cbdea7ef-3204-4e61-a716-0f75432e126a"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Greater").Id,
                Level = 8,
                Price = 9000,
                Benefits = "The duration is 24 hours.",
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d6014ec-8673-4ab8-b0ed-4ab1690a713c"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 547
            };
        }
    }
}
