using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class AcidFlask : Template
    {
        public static readonly Guid ID = Guid.Parse("05e7fbc0-da5c-4194-bd5a-daa6b05ba421");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Acid Flask",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Bomb.ID;
            yield return Traits.Instances.Acid.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Splash.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("575fcbde-26ab-4b04-8856-d3ff1612f7f3"), Text = "This flask filled with corrosive acid deals 1 acid damage, the listed persistent acid damage, and the listed acid splash damage. Many types grant an item bonus to attack rolls." };
        }

        protected override IEnumerable<AlchemicalBombPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("5929e181-19f4-45bf-9d37-8ac1d3018211"),
                Level = 1,
                Benefits = "It deals 1d6 persistent acid damage and 1 acid splash damage.",
                Price = 300,
                PotionPotencyId = Potencies.Instances.Lesser.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("a96f62ca-457c-4e96-8271-a134db850874"),
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls. The bomb deals 2d6 persistent acid damage and 2 acid splash damage.",
                Price = 1000,
                PotionPotencyId = Potencies.Instances.Moderate.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("080939ae-8ab4-4b7a-986e-861ba3828efc"),
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls. The bomb deals 3d6 persistent acid damage and 3 acid splash damage.",
                Price = 25000,
                PotionPotencyId = Potencies.Instances.Greater.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("ec84fb6f-a71f-44a8-8064-7d41cfd4d565"),
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls. The bomb deals 4d6 persistent acid damage and 4 acid splash damage.",
                Price = 250000,
                PotionPotencyId = Potencies.Instances.Major.ID
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05e99663-a3fb-498d-8cdb-702190ac8f65"),
                SourceId = CoreRulebook.ID,
                Page = 544
            };
        }
    }
}
