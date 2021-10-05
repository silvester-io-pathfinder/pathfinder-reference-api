using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class SeaTouchElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("ceaaac90-8340-4e2a-aa97-effc5848f12d");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Sea Touch Elixir",
                Usage = "Held in 1 hand",
                ItemBonus = 5,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Polymorph.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d023119-60ec-4f88-9056-c3b81e0af2bf"), Text = "This briny concoction alters the skin on your hands and feet. The spaces between your fingers and toes become webbed, granting you a swim Speed of 20 feet for the listed duration." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("b9e3fce6-156b-4ff8-b412-81d3250d6713"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 5,
                Price = 2200,
                Benefits = "The duration is 10 minutes."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("8f3626ff-346a-4eb1-ad3b-82ac2c1060f4"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 12,
                Price = 30000,
                Benefits = "The duration is 1 hour, and you can breathe underwater."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("e76fa208-fe2c-41f5-8cf6-21c46064a190"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 15,
                Price = 92000,
                Benefits = "The duration is 24 hours, and you can breathe underwater."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a83ecdc-9097-475c-a98e-1240f6dda74b"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
