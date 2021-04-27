using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs.Instances
{
    public class BottledLightning : AbstractAlchemicalBombTemplate
    {
        public static readonly Guid ID = Guid.Parse("2a6ab15a-5dd7-4c2c-b551-500821023ac7");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                ActionId = Strike.ID,
                Name = "Bottled Lightning",
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
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Splash.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d487c00d-1ea3-4f9a-83cd-eba70c9614fd"), Text = "Bottled lightning is packed with volatile reagents that create a blast of electricity when they are exposed to air. Bottled lightning deals the listed electricity damage and electricity splash damage. On a hit, the target becomes flat-footed until the start of your next turn. Many types grant an item bonus to attack rolls." };
        }

        protected override IEnumerable<AlchemicalBombPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("0733aabb-aa51-4405-a5fa-d8368288f106"),
                Level = 1,
                Benefits = "It deals 1d6 electricity damage and 1 electricity splash damage.",
                Price = 300,
                PotionPotencyId = Potencies.Instances.Lesser.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("26abf99d-95ab-46a8-af26-3fac3af578be"),
                Level = 3,
                Benefits = "You gain a +1 item bonus to attack rolls. The bomb deals 2d6 electricity damage and 2 electricity splash damage.",
                Price = 1000,
                PotionPotencyId = Potencies.Instances.Moderate.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("449e0cb8-5e05-42ea-b12a-73d059829315"),
                Level = 11,
                Benefits = "You gain a +2 item bonus to attack rolls. The bomb deals 3d6 electricity damage and 3 electricity splash damage.",
                Price = 25000,
                PotionPotencyId = Potencies.Instances.Greater.ID
            };

            yield return new AlchemicalBombPotencyBinding
            {
                Id = Guid.Parse("41e63f50-d1c8-400a-a74b-8299172bdf08"),
                Level = 17,
                Benefits = "You gain a +3 item bonus to attack rolls. The bomb deals 4d6 electricity damage and 4 electricity splash damage.",
                Price = 250000,
                PotionPotencyId = Potencies.Instances.Major.ID
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e69c3d9f-ec8d-43d5-89b4-68c8aae4eafa"),
                SourceId = CoreRulebook.ID,
                Page = 544
            };
        }
    }
}
