using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class BottledLightning : AbstractAlchemicalBombTemplate
    {
        public static readonly Guid ID = Guid.Parse("2a6ab15a-5dd7-4c2c-b551-500821023ac7");

        protected override AlchemicalBomb GetAlchemicalBomb(AlchemicalBombSeeder seeder)
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Bottled Lightning",
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
            yield return "Electricity";
            yield return "Splash";
        }

        protected override IEnumerable<AlchemicalBombDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalBombDetailBlock { Id = Guid.Parse("d487c00d-1ea3-4f9a-83cd-eba70c9614fd"), Text = "Bottled lightning is packed with volatile reagents that create a blast of electricity when they are exposed to air. Bottled lightning deals the listed electricity damage and electricity splash damage. On a hit, the target becomes flat-footed until the start of your next turn. Many types grant an item bonus to attack rolls." };
        }

        protected override IEnumerable<AlchemicalBombPotencyBinding> GetPotencies(AlchemicalBombSeeder seeder)
        {
            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("0733aabb-aa51-4405-a5fa-d8368288f106"),
                Level = 1,
                Benefits = "It deals 1d6 electricity damage and 1 electricity splash damage.",
                Price = 300,
                PotionPotencyId = seeder.GetPotionPotencyByName("Lesser").Id
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("26abf99d-95ab-46a8-af26-3fac3af578be"),
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls. The bomb deals 2d6 electricity damage and 2 electricity splash damage.",
                Price = 1000,
                PotionPotencyId = seeder.GetPotionPotencyByName("Moderate").Id
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("449e0cb8-5e05-42ea-b12a-73d059829315"),
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls. The bomb deals 3d6 electricity damage and 3 electricity splash damage.",
                Price = 25000,
                PotionPotencyId = seeder.GetPotionPotencyByName("Greater").Id
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("41e63f50-d1c8-400a-a74b-8299172bdf08"),
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls. The bomb deals 4d6 electricity damage and 4 electricity splash damage.",
                Price = 250000,
                PotionPotencyId = seeder.GetPotionPotencyByName("Major").Id
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalBombSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("e69c3d9f-ec8d-43d5-89b4-68c8aae4eafa"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 544
            };
        }
    }
}
