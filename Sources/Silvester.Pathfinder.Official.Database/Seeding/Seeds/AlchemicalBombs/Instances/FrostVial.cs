using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class FrostVial : Template
    {
        public static readonly Guid ID = Guid.Parse("f121fc6c-44bd-4528-9673-709f81627688");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Frost Vial",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Bomb.ID;
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Splash.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a949c9e-d4c8-4496-bb1a-71fea4bef008"), Text = "The liquid reagents in this vial rapidly absorb heat when exposed to air. A frost vial deals the listed cold damage and cold splash damage. On a hit, the target takes a status penalty to its Speeds until the end of its next turn. Many types of frost vial also grant an item bonus to attack rolls." };
        }

        protected override IEnumerable<AlchemicalBombPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("9d329a79-8888-4d7a-b0b5-07cc3a58ccaf"),
                Level = 1,
                Benefits = "The bomb deals 1d6 cold damage and 1 cold splash damage, and the target takes a –5-foot penalty.",
                Price = 300,
                PotionPotencyId = Potencies.Instances.Lesser.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("f77093af-ad47-474a-b8cd-b1913ec62145"),
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls, the bomb deals 2d6 cold damage and 2 cold splash damage, and the target takes a –10-foot penalty.",
                Price = 1000,
                PotionPotencyId = Potencies.Instances.Moderate.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("ec955cf0-b5c3-43f1-90ee-c3aaeae9d329"),
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls, the bomb deals 3d6 cold damage and 3 cold splash damage, and the target takes a –10-foot penalty.",
                Price = 25000,
                PotionPotencyId = Potencies.Instances.Greater.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("d0289952-2f3e-4bfd-baa0-3209e37da2b6"),
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls, the bomb deals 4d6 cold damage and 4 cold splash damage, and the target takes a –15-foot penalty.",
                Price = 250000,
                PotionPotencyId = Potencies.Instances.Major.ID
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af1a9b81-dd1c-4fb3-8266-c9f932ce4e88"),
                SourceId = CoreRulebook.ID,
                Page = 545
            };
        }
    }
}
