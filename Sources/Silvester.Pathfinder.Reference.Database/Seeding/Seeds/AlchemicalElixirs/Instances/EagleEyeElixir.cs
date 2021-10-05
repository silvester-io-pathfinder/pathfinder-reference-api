using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class EagleEyeElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("e81eb16e-db86-4869-9cc7-1b5dfa3ba787");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Eagle-Eye Elixir",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
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
            yield return new TextBlock { Id = Guid.Parse("fc565a61-6754-4bea-bdc6-768b53993621"), Text = "After you drink this elixir, you notice subtle visual details. For the next hour, you gain an item bonus to Perception checks that is greater when attempting to find secret doors and traps." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("b38c09ea-4d70-41b1-8abe-f1e564fca8f6"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 400,
                Benefits = "The bonus is +1, or +2 to find secret doors and traps.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("8a7a3827-e85a-4640-8ac2-e8ee126c858c"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 5,
                Price = 2700,
                Benefits = "The bonus is +2, or +3 to find secret doors and traps.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("088a145b-55c6-498a-84fe-19a05c03b0aa"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 10,
                Price = 20000,
                Benefits = "The bonus is +3, or +4 to find secret doors and traps.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("f40a6267-87fa-4c89-a824-2dc1a54e2b55"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 16,
                Price = 200000,
                Benefits = "The bonus is +3, or +4 to find secret doors and traps. Each time you pass within 10 feet of a secret door or trap, the GM automatically rolls a secret check for you to find it.",
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45fac17c-ce11-475b-9f6d-fd2b4fabcee4"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
