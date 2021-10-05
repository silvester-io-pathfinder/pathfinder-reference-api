using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class BravosBrew : Template
    {
        public static readonly Guid ID = Guid.Parse("8d0d85f9-d1bf-49c2-ab32-d6caa627de83");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Bravo's Brew",
                Usage = "Held in 1 hand",
                ItemBonus = 2,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bed0c6dc-af90-431a-93a5-f6a126f7e4d2"), Text = "This flask of foaming beer grants courage. For the next hour after drinking this elixir, you gain an item bonus to Will saves, which is greater when attempting Will saves against fear." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("e35d119e-d943-4fac-be53-d75d079be8c4"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 2,
                Price = 700,
                Benefits = "The bonus on Will saves is +1, or +2 against fear.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("924eb7b5-50b7-48d8-857d-18dd705ec6ab"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 10,
                Price = 15000,
                Benefits = "The bonus on Will saves is +2, or +3 against fear.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("198da97d-cf25-453b-93ce-94591ba46529"),
                PotionPotencyId = Potencies.Instances.Greater.ID,

                Level = 15,
                Price = 70000,
                Benefits = "The bonus on Will saves is +3, or +4 against fear. If you roll a success on a save against fear, you get a critical success instead.",
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b4598c1-dd52-41da-aadb-13768ee8f885"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
