using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class CatsEyeElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("9273e6ad-3f3c-4e7d-9b9c-4a8faec61145");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Cat's Eye Elixir",
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
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70db1dfe-abca-4416-b8ba-8825604c77d9"), Text = "After you consume this elixir, your vision sharpens and you become sensitive to even the most minute movements. For the next minute, you reduce the flat check to target hidden creatures to 5, and you don't need to attempt a flat check to target concealed creatures. These benefits apply only against creatures within 30 feet of you." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("39b6c273-ce0b-46a5-ab96-6603a5d79ed4"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 700,
                Benefits = "The Cat's Eye Elixir only exists in a single form, so no other potencies exist."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6773943d-c2fc-4e8a-ba93-e1d4d9766757"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
