using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class BravosBrew : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("8d0d85f9-d1bf-49c2-ab32-d6caa627de83");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Bravo's Brew",
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

        protected override IEnumerable<AlchemicalElixirDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalElixirDetailBlock { Id = Guid.Parse("bed0c6dc-af90-431a-93a5-f6a126f7e4d2"), Text = "This flask of foaming beer grants courage. For the next hour after drinking this elixir, you gain an item bonus to Will saves, which is greater when attempting Will saves against fear." };
        }


        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("e35d119e-d943-4fac-be53-d75d079be8c4"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id,
                Level = 2,
                Price = 700,
                Benefits = "The bonus on Will saves is +1, or +2 against fear.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("924eb7b5-50b7-48d8-857d-18dd705ec6ab"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Moderate").Id,
                Level = 10,
                Price = 15000,
                Benefits = "The bonus on Will saves is +2, or +3 against fear.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("198da97d-cf25-453b-93ce-94591ba46529"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Greater").Id,

                Level = 15,
                Price = 70000,
                Benefits = "The bonus on Will saves is +3, or +4 against fear. If you roll a success on a save against fear, you get a critical success instead.",
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b4598c1-dd52-41da-aadb-13768ee8f885"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 547
            };
        }
    }
}
