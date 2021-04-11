using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class Thunderstone : AbstractAlchemicalBombTemplate
    {
        public static readonly Guid ID = Guid.Parse("cdfc6ce6-04ca-4220-a5c6-73eee8d2f0d5");

        protected override AlchemicalBomb GetAlchemicalBomb(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Thunderstone",
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
            yield return "Sonic";
            yield return "Splash";
        }

        protected override IEnumerable<AlchemicalBombDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalBombDetailBlock { Id = Guid.Parse("670226b5-e794-4898-b2be-94c63cf5408e"), Text = "When this stone hits a creature or a hard surface, it explodes with a deafening bang. A thunderstone deals the listed sonic damage and sonic splash damage, and each creature within 10 feet of the space in which the stone exploded must succeed at a Fortitude saving throw with the listed DC or be deafened until the end of its next turn. Many types of thunderstone grant an item bonus to attack rolls." };
        }

        protected override AlchemicalBombPotencyBinding GetLesserPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 1,
                Benefits = "The bomb deals 1d4 sonic damage and 1 sonic splash damage, and the DC is 17.",
                Price = 300
            };
        }

        protected override AlchemicalBombPotencyBinding GetModeratePotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls. The bomb deals 2d4 sonic damage and 2 sonic splash damage, and the DC is 20.",
                Price = 1000
            };

        }

        protected override AlchemicalBombPotencyBinding GetGreaterPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls. The bomb deals 3d4 sonic damage and 3 sonic splash damage, and the DC is 28.",
                Price = 25000
            };
        }

        protected override AlchemicalBombPotencyBinding GetMajorPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls. The bomb deals 4d4 sonic damage and 4 sonic splash damage, and the DC is 36.",
                Price = 250000
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalBombSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("797f5f94-6919-4064-9fde-9823f4bc73b9"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 546
            };
        }
    }
}
