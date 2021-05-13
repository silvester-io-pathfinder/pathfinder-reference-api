using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class LeapersElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("fce1d931-7808-4e03-8615-f9f0210c405a");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Leaper's Elixir",
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
            yield return new TextBlock { Id = Guid.Parse("83785b35-3536-4517-8ad1-e06c530cba25"), Text = "This tingly solution increases the elasticity and contraction of your leg muscles. For 1 minute after drinking this elixir, you can High Jump or Long Jump as a single action instead of 2 actions. If you do, you don’t perform the initial Stride (nor do you fail if you don’t Stride 10 feet)." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("7e27f203-866b-4aa0-aa90-eac4ddeb63dd"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 300,
                Benefits = "No explicit benefits are listed for the Lesser potency."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("cb54c6f2-efc7-4075-b4eb-441986ce1558"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 7,
                Price = 3500,
                Benefits = "The maximum vertical distance you can jump with a High Jump is the same as you can jump horizontally with a Long Jump."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb4cba35-f753-4922-b078-0dfbcff780f2"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
