using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class StoneFistElixir : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("58f3f7fd-4244-4a42-b684-d995220d4ade");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Stone Fist Elixir",
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
            yield return Traits.Instances.Morph.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdcd2d5b-5901-4d52-81b9-7645684928c0"), Text = "Your fists become hard as stone. For 1 hour, your fists deal 1d6 bludgeoning damage and lose the nonlethal trait." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("e393357d-29cf-42ba-bbab-01f227faebfb"),
                PotionPotencyId = Potencies.Instances.Unclassified.ID,
                Level = 4,
                Price = 1300,
                Benefits = "The Stone Fist Elixir only exists as a single unclassified potency."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87156a04-1bcc-4ec5-a7b6-ad44e0189935"),
                SourceId = CoreRulebook.ID,
                Page = 550
            };
        }
    }
}
