using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class FrostVial : AbstractAlchemicalBombTemplate
    {
        public static readonly Guid ID = Guid.Parse("f121fc6c-44bd-4528-9673-709f81627688");

        protected override AlchemicalBomb GetAlchemicalBomb(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Frost Vial",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = seeder.GetBulkByName("L").Id
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Bomb";
            yield return "Cold";
            yield return "Consumable";
            yield return "Splash";
        }

        protected override IEnumerable<AlchemicalBombDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalBombDetailBlock { Id = Guid.Parse("3a949c9e-d4c8-4496-bb1a-71fea4bef008"), Text = "The liquid reagents in this vial rapidly absorb heat when exposed to air. A frost vial deals the listed cold damage and cold splash damage. On a hit, the target takes a status penalty to its Speeds until the end of its next turn. Many types of frost vial also grant an item bonus to attack rolls." };
        }

        protected override AlchemicalBombPotencyBinding GetLesserPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 1,
                Benefits = "The bomb deals 1d6 cold damage and 1 cold splash damage, and the target takes a –5-foot penalty.",
                Price = 300
            };
        }

        protected override AlchemicalBombPotencyBinding GetModeratePotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls, the bomb deals 2d6 cold damage and 2 cold splash damage, and the target takes a –10-foot penalty.",
                Price = 1000
            };

        }

        protected override AlchemicalBombPotencyBinding GetGreaterPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls, the bomb deals 3d6 cold damage and 3 cold splash damage, and the target takes a –10-foot penalty.",
                Price = 25000
            };
        }

        protected override AlchemicalBombPotencyBinding GetMajorPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls, the bomb deals 4d6 cold damage and 4 cold splash damage, and the target takes a –15-foot penalty.",
                Price = 250000
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalBombSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("af1a9b81-dd1c-4fb3-8266-c9f932ce4e88"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 545
            };
        }
    }
}
