using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class AlchemistsFire : AbstractAlchemicalBombTemplate
    {
        public static readonly Guid ID = Guid.Parse("3e95680d-1c87-457c-91b0-e6e5cf29bee8");

        protected override AlchemicalBomb GetAlchemicalBomb(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Alchemist's Fire",
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
            yield return "Fire";
            yield return "Splash";
        }

        protected override IEnumerable<AlchemicalBombDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalBombDetailBlock { Id = Guid.Parse("7ea74824-5235-4b72-bc3e-813400c45c57"), Text = "Alchemist’s fire is a combination of volatile liquids that ignite when exposed to air. Alchemist’s fire deals the listed fire damage, persistent fire damage, and splash damage. Many types grant an item bonus to attack rolls." };
        }

        protected override AlchemicalBombPotencyBinding GetLesserPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 1,
                Benefits = "The bomb deals 1d8 fire damage, 1 persistent fire damage, and 1 fire splash damage.",
                Price = 300
            };
        }

        protected override AlchemicalBombPotencyBinding GetModeratePotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls. The bomb deals 2d8 fire damage, 2 persistent fire damage, and 2 fire splash damage.",
                Price = 1000
            };

        }

        protected override AlchemicalBombPotencyBinding GetGreaterPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls. The bomb deals 3d8 fire damage, 3 persistent fire damage, and 3 fire splash damage.",
                Price = 25000
            };
        }

        protected override AlchemicalBombPotencyBinding GetMajorPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls. The bomb deals 4d8 fire damage, 4 persistent fire damage, and 4 fire splash damage.",
                Price = 250000
            };
        }


        protected override SourcePage? GetSourcePage(AlchemicalBombSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ea74824-5235-4b72-bc3e-813400c45c57"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 545
            };
        }
    }
}
