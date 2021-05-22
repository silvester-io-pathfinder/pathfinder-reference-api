using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class Thunderstone : Template
    {
        public static readonly Guid ID = Guid.Parse("cdfc6ce6-04ca-4220-a5c6-73eee8d2f0d5");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Thunderstone",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Bomb.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Sonic.ID;
            yield return Traits.Instances.Splash.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("670226b5-e794-4898-b2be-94c63cf5408e"), Text = "When this stone hits a creature or a hard surface, it explodes with a deafening bang. A thunderstone deals the listed sonic damage and sonic splash damage, and each creature within 10 feet of the space in which the stone exploded must succeed at a Fortitude saving throw with the listed DC or be deafened until the end of its next turn. Many types of thunderstone grant an item bonus to attack rolls." };
        }

        protected override IEnumerable<AlchemicalBombPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("2442bad4-86cc-4145-bee7-d696a7ccb2cc"),
                Level = 1,
                Benefits = "The bomb deals 1d4 sonic damage and 1 sonic splash damage, and the DC is 17.",
                Price = 300,
                PotionPotencyId = Potencies.Instances.Lesser.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("592cf1a3-5509-4b31-b436-c5ccd88e9b59"),
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls. The bomb deals 2d4 sonic damage and 2 sonic splash damage, and the DC is 20.",
                Price = 1000,
                PotionPotencyId = Potencies.Instances.Moderate.ID
            };
          
            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("8a0c09f3-8d30-4bb6-b6e3-19b9f7b87f13"),
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls. The bomb deals 3d4 sonic damage and 3 sonic splash damage, and the DC is 28.",
                Price = 25000,
                PotionPotencyId = Potencies.Instances.Greater.ID
            };
         
            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("e2361f6e-5c3d-4caa-a11d-e55d5dda3f2a"),
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls. The bomb deals 4d4 sonic damage and 4 sonic splash damage, and the DC is 36.",
                Price = 250000,
                PotionPotencyId = Potencies.Instances.Major.ID
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("797f5f94-6919-4064-9fde-9823f4bc73b9"),
                SourceId = CoreRulebook.ID,
                Page = 546
            };
        }
    }
}
