using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class SereneMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("baf67e26-cdcd-48fc-b64a-2e68c08bef03");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Serene Mutagen",
                Usage = "Held in 1 hand",
                Benefit = "You gain an item bonus to Will saves and Perception, Medicine, Nature, Religion, and Survival checks. This bonus improves when you attempt Will saves against mental effects.",
                Drawback = "You take a –1 penalty to attack rolls and save DCs of offensive spells, and a –1 penalty per damage die to all weapon, unarmed attack, and spell damage.",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Mutagen.ID;
            yield return Traits.Instances.Polymorph.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26d53eae-b1d3-4e3c-81d1-83d6d86633df"), Text = "You gain inner serenity, focused on fine details and steeled against mental assaults, but you find violence off-putting." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("4ddd60e2-ca4d-4083-abb2-e59eba12ebc9"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 400,
                Benefits = "The bonus is +1, or +2 vs. mental, and the duration is 1 minute."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("34301c2f-2b01-465c-bdf2-e7b562745d59"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 3,
                Price = 1200,
                Benefits = "The bonus is +2, or +3 vs. mental, and the duration is 10 minutes."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("a181f368-f4e7-4dc9-add0-f8fd91c1e82e"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 11,
                Price = 30000,
                Benefits = "The bonus is +3, or +4 vs. mental, and the duration is 1 hour. When you roll a success on a Will save against a mental effect, you get a critical success instead."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("c25492a4-eb51-4284-9322-13910d9cd42b"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 17,
                Price = 3000,
                Benefits = "The bonus is +4, and the duration is 1 hour. When you roll a success on a Will save against a mental effect, you get a critical success instead, and your critical failures on Will saves against mental effects become failures instead."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94b98608-9ba0-46c2-9793-e5421daeb22a"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
