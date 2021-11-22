using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class QuicksilverMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("eeca589b-c156-4a4a-8614-d78cc53934c1");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Quicksilver Mutagen",
                Usage = "Held in 1 hand",
                Benefit = "You gain an item bonus to Acrobatics checks, Stealth checks, Thievery checks, Reflex saves, and Dexterity-based attack rolls, and you gain the listed status bonus to your Speed.",
                Drawback = "You take damage equal to twice your level; you can't recover Hit Points lost in this way by any means while the mutagen lasts. You take a –2 penalty to Fortitude saves.",
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
            yield return new TextBlock { Id = Guid.Parse("ad64a881-6dc8-4752-8c71-e3486b4977bc"), Text = "Your features become thin and angular. You become swifter and nimbler, but your body also becomes fragile." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("598c5a4c-6040-442d-bbf2-7f21e072a143"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 400,
                Benefits = "The bonus to rolls is +1, the bonus to Speed is +5 feet, and the duration is 1 minute."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("68101420-8854-4e3c-a8cc-3ff62b531a13"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 3,
                Price = 1200,
                Benefits = "The bonus to rolls is +2, the bonus to Speed is +10 feet, and the duration is 10 minutes."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("d57cc4b4-6527-45cd-8fbf-cb1574460ed0"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 11,
                Price = 30000,
                Benefits = "The bonus to rolls is +3, the bonus to Speed is +15 feet, and the duration is 1 hour."
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("c4b8ef3f-b0ba-4fbc-92e1-a4824ccd8713"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 17,
                Price = 300000,
                Benefits = "The bonus to rolls is +4, the bonus to Speed is +20 feet, and the duration is 1 hour."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fbd3dd2-ede6-4021-8311-36ea949ff120"),
                SourceId = CoreRulebook.ID,
                Page = 549
            };
        }
    }
}
