using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class TanglefootBag : AbstractAlchemicalBombTemplate
    {
        public static readonly Guid ID = Guid.Parse("e7825926-436e-4914-940a-09de6052cab1");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Tanglefoot Bag",
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
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7f13e63-3728-470d-8a1f-b7cd65d855df"), Text = "A tanglefoot bag is filled with sticky substances. When you hit a creature with a tanglefoot bag, that creature takes a status penalty to its Speeds for 1 minute. Many types of tanglefoot bag also grant an item bonus on attack rolls." };
            yield return new TextBlock { Id = Guid.Parse("694ea8b3-8bd7-4a4e-b925-446ba77959f6"), Text = "On a critical hit, a creature in contact with a solid surface becomes stuck to the surface and immobilized for 1 round, and a creature flying via wings has its wings tangled, causing it to fall safely to the ground and become unable to Fly again for 1 round. Tanglefoot bags are not effective when used on a creature that is in water." };
            yield return new TextBlock { Id = Guid.Parse("3d23b44a-67d3-4cbe-b73e-528f36790ac4"), Text = "The target can end any effects by Escaping or spending a total of 3 Interact actions to carefully remove the sticky substances. These Interact actions don’t have to be consecutive, and other creatures can provide the actions as well." };
        }

        protected override IEnumerable<AlchemicalBombPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("294e2585-b769-4685-8a98-5174ec4d4fc2"),
                Level = 1,
                Benefits = "The target takes a –10-foot penalty, and the Escape DC is 17.",
                Price = 300,
                PotionPotencyId = Potencies.Instances.Lesser.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("6778bc68-53d6-4432-8f96-ccca5073ee48"),
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls, the target takes a –15-foot penalty, and the Escape DC is 19.",
                Price = 1000,
                PotionPotencyId = Potencies.Instances.Moderate.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("44ac5c08-5ccd-4cba-b822-f4b6a37573c4"),
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls, the target takes a –15-foot penalty, and the Escape DC is 28.",
                Price = 25000,
                PotionPotencyId = Potencies.Instances.Greater.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("ebfa4694-3931-4d55-9b70-ac6cc73e2837"),
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls, the target takes a –20-foot penalty, and the Escape DC is 37.",
                Price = 250000,
                PotionPotencyId = Potencies.Instances.Major.ID
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3cc038d-b67e-4cf7-a23e-cdb9464ad5a8"),
                SourceId = CoreRulebook.ID,
                Page = 545
            };
        }
    }
}
