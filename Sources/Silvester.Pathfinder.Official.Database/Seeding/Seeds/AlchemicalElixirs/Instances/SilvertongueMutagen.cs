using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class SilvertongueMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("a4700423-ee77-4ed2-ac68-682da90db27b");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Silvertongue Mutagen",
                Usage = "Held in 1 hand",
                Benefit = "You gain an item bonus to Deception, Diplomacy, Intimidation, and Performance checks. Your critical failures with any of these skills become failures instead.",
                Drawback = "You take a –2 item penalty to Arcana, Crafting, Lore, Occultism, and Society checks. Choose one skill in which you are trained; for the duration, you become untrained in that skill. All your failures on checks to Recall Knowledge become critical failures.",
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
            yield return new TextBlock { Id = Guid.Parse("9b681339-c92a-45b5-9bed-aebedf317e72"), Text = "Your features become striking and your voice becomes musical and commanding, though facts and figures become hazy for you and emotion clouds your ability to reason." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("b056b057-9364-483b-bdba-4cfe7def1f5e"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 400,
                Benefits = "The bonus is +1, and the duration is 1 minute."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("8ce0fa7d-20be-4e6f-a187-ec5dea1195d4"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 3,
                Price = 1200,
                Benefits = "The bonus is +2, and the duration is 10 minutes."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("3dfcbecf-41ba-4742-b096-fab4c9d371bc"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 11,
                Price = 30000,
                Benefits = "The bonus is +3, and the duration is 1 hour."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("0ac53999-7bc7-4e2d-a23c-528b063faf68"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 17,
                Price = 300000,
                Benefits = "The bonus is +4, and the duration is 1 hour."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1960b59-9b61-4f34-adbb-3ce997fc0fda"),
                SourceId = CoreRulebook.ID,
                Page = 550
            };
        }
    }
}
