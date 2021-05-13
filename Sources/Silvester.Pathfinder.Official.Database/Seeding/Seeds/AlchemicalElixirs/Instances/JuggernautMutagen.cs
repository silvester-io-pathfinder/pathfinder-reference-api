using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class JuggernautMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("64cc1e8c-d5c1-4e58-9306-3be2e06a95b9");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Juggernaut Mutagen",
                Usage = "Held in 1 hand",
                Benefit = "You gain an item bonus to Fortitude saves and the listed number of temporary Hit Points. Whenever you are at maximum Hit Points for at least 1 full minute, you regain the temporary Hit Points.",
                Drawback = "You take a –2 penalty to Will saves, Perception checks, and initiative rolls.",
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
            yield return new TextBlock { Id = Guid.Parse("04d5224a-86f5-4533-a931-a1b465cbac1c"), Text = "After you drink this mutagen, your body becomes thick and sturdy. You exhibit a healthy glow, though you tend to be ponderous and unobservant." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("1b1ff22d-3fa6-478f-baec-36db27dc91f9"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 400,
                Benefits = "The bonus is +1, you gain 5 temporary Hit Points, and the duration is 1 minute."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("7784be12-0f34-455d-83cd-a77ed2ccc458"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 3,
                Price = 1200,
                Benefits = "The bonus is +2, you gain 10 temporary Hit Points, and the duration is 10 minutes."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("8ae2a6d5-6e36-48ae-b1bb-41698dd0803d"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 11,
                Price = 30000,
                Benefits = "The bonus is +3, you gain 30 temporary Hit Points, and the duration is 1 hour. When you roll a success on a Fortitude save, you get a critical success instead."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("c10dc1eb-97c5-40ea-9aa3-ca19b2f701ee"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 17,
                Price = 300000,
                Benefits = "The bonus is +4, you gain 45 temporary Hit Points, and the duration is 1 hour. When you roll a success on a Fortitude save, you get a critical success instead, and your critical failures on Fortitude saves become failures instead."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c10dc1eb-97c5-40ea-9aa3-ca19b2f701ee"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
