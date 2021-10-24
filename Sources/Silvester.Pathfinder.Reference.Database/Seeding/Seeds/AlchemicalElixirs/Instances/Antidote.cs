using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class Antidote : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Antidote",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Healing.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Text = "An antidote protects you against toxins. Upon drinking an antidote, you gain an item bonus to Fortitude saving throws against poisons for 6 hours." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse(""),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 300,
                Benefits = "You gain a +2 item bonus.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse(""),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 6,
                Price = 3500,
                Benefits = "You gain a +3 item bonus.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse(""),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 10,
                Price = 16000,
                Benefits = "You gain a +4 item bonus.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse(""),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 14,
                Price = 67500,
                Benefits = "You gain a +4 item bonus, and when you drink the antidote, you can immediately attempt a save against one poison of 14th level or lower affecting you. If you succeed, the poison is neutralized.",
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ef3438b-f3b0-4362-85bf-3d1f55ec01ac"),
                SourceId = CoreRulebook.ID,
                Page = 546
            };
        }
    }
}
