using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class BombersEyeElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("c1fbd9e7-e36e-49d7-b3c2-772400e1fc5e");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Bomber's Eye Elixir",
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
            yield return new TextBlock { Id = Guid.Parse("47c254c1-8659-4363-8818-143300056126"), Text = "This tincture lets you pinpoint your foes. For the next 5 minutes, your alchemical bomb Strikes reduce the circumstance bonus to AC your targets gain from cover." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("e87ddbd9-2e31-4b10-b0db-07f4d4ca71c9"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 4,
                Price = 1400,
                Benefits = "Reduce your targets’ circumstance bonus by 1."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("1c6bf9da-9e46-4f5e-9703-5d48a5a59f73"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 14,
                Price = 70000,
                Benefits = "Reduce your targets’ circumstance bonus by 2."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("059586d6-6a3c-4369-b92b-4f589f1d0323"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
