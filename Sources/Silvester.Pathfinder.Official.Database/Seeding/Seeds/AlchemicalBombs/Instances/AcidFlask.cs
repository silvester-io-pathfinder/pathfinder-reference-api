using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class AcidFlask : AbstractAlchemicalBombTemplate
    {
        public static readonly Guid ID = Guid.Parse("05e7fbc0-da5c-4194-bd5a-daa6b05ba421");

        protected override AlchemicalBomb GetAlchemicalBomb(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Acid Flask",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = seeder.GetBulkByName("L").Id
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Bomb";
            yield return "Acid";
            yield return "Consumable";
            yield return "Splash";
        }

        protected override IEnumerable<AlchemicalBombDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalBombDetailBlock { Id = Guid.Parse("575fcbde-26ab-4b04-8856-d3ff1612f7f3"), Text = "This flask filled with corrosive acid deals 1 acid damage, the listed persistent acid damage, and the listed acid splash damage. Many types grant an item bonus to attack rolls." };
        }

        protected override AlchemicalBombPotencyBinding GetLesserPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 1,
                Benefits = "It deals 1d6 persistent acid damage and 1 acid splash damage.",
                Price = 300
            };
        }

        protected override AlchemicalBombPotencyBinding GetModeratePotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls. The bomb deals 2d6 persistent acid damage and 2 acid splash damage.",
                Price = 1000
            };

        }

        protected override AlchemicalBombPotencyBinding GetGreaterPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls. The bomb deals 3d6 persistent acid damage and 3 acid splash damage.",
                Price = 25000
            };
        }

        protected override AlchemicalBombPotencyBinding GetMajorPotency(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBombPotencyBinding
            {
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls. The bomb deals 4d6 persistent acid damage and 4 acid splash damage.",
                Price = 250000
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalBombSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("05e99663-a3fb-498d-8cdb-702190ac8f65"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 544
            };
        }
    }
}
