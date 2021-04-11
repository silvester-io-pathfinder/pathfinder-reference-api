using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class TanglefootBag : AbstractAlchemicalBombTemplate
    {
        public static readonly Guid ID = Guid.Parse("e7825926-436e-4914-940a-09de6052cab1");

        protected override AlchemicalBomb GetAlchemicalBomb(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Tanglefoot Bag",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = seeder.GetBulkByName("L").Id
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Bomb";
            yield return "Consumable";
        }

        protected override IEnumerable<AlchemicalBombDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalBombDetailBlock { Id = Guid.Parse("f7f13e63-3728-470d-8a1f-b7cd65d855df"), Text = "A tanglefoot bag is filled with sticky substances. When you hit a creature with a tanglefoot bag, that creature takes a status penalty to its Speeds for 1 minute. Many types of tanglefoot bag also grant an item bonus on attack rolls." };
            yield return new AlchemicalBombDetailBlock { Id = Guid.Parse("694ea8b3-8bd7-4a4e-b925-446ba77959f6"), Text = "On a critical hit, a creature in contact with a solid surface becomes stuck to the surface and immobilized for 1 round, and a creature flying via wings has its wings tangled, causing it to fall safely to the ground and become unable to Fly again for 1 round. Tanglefoot bags are not effective when used on a creature that is in water." };
            yield return new AlchemicalBombDetailBlock { Id = Guid.Parse("3d23b44a-67d3-4cbe-b73e-528f36790ac4"), Text = "The target can end any effects by Escaping or spending a total of 3 Interact actions to carefully remove the sticky substances. These Interact actions don’t have to be consecutive, and other creatures can provide the actions as well." };
        }

        protected override AlchemicalBombPotencyBinding GetLesserPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 1,
                Benefits = "The target takes a –10-foot penalty, and the Escape DC is 17.",
                Price = 300
            };
        }

        protected override AlchemicalBombPotencyBinding GetModeratePotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls, the target takes a –15-foot penalty, and the Escape DC is 19.",
                Price = 1000
            };

        }

        protected override AlchemicalBombPotencyBinding GetGreaterPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls, the target takes a –15-foot penalty, and the Escape DC is 28.",
                Price = 25000
            };
        }

        protected override AlchemicalBombPotencyBinding GetMajorPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls, the target takes a –20-foot penalty, and the Escape DC is 37.",
                Price = 250000
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalBombSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3cc038d-b67e-4cf7-a23e-cdb9464ad5a8"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 545
            };
        }
    }
}
