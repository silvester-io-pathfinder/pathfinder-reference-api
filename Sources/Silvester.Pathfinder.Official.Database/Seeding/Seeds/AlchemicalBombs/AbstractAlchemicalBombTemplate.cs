using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs
{
    public abstract class AbstractAlchemicalBombTemplate
    {
        public void Seed(AlchemicalBombSeeder seeder)
        {
            AlchemicalBomb bomb = GetAlchemicalBomb(seeder);

            SourcePage? sourcePage = GetSourcePage(seeder);
            if (sourcePage != null)
            {
                seeder.Builder.AddData(sourcePage);
                bomb.SourcePageId = sourcePage.SourceId;
            }

            foreach (AlchemicalBombDetailBlock detailBlock in GetDetailBlocks())
            {
                detailBlock.AlchemicalBombId = bomb.Id;
                seeder.Builder.AddData(detailBlock);
            }

            SeedPotencyBinding(seeder, bomb, GetLesserPotency(seeder), "Lesser", 1);
            SeedPotencyBinding(seeder, bomb, GetModeratePotency(seeder), "Moderate", 2);
            SeedPotencyBinding(seeder, bomb, GetGreaterPotency(seeder), "Greater", 3);
            SeedPotencyBinding(seeder, bomb, GetMajorPotency(seeder), "Major", 4);

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((bomb, trait));
            }

            seeder.Builder.AddData(bomb);
        }

        private static void SeedPotencyBinding(AlchemicalBombSeeder seeder, AlchemicalBomb bomb, AlchemicalBombPotencyBinding binding, string potencyName, int incrementIdBy)
        {
            binding.PotionPotencyId = seeder.GetPotionPotencyByName(potencyName).Id;
            binding.Id = bomb.Id.Increment(incrementIdBy);
            binding.AlchemicalBombId = bomb.Id;

            seeder.Builder.AddData(binding);
        }

        protected abstract AlchemicalBomb GetAlchemicalBomb(AlchemicalBombSeeder seeder);
        protected abstract SourcePage? GetSourcePage(AlchemicalBombSeeder seeder);
        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<AlchemicalBombDetailBlock> GetDetailBlocks();
        protected abstract AlchemicalBombPotencyBinding GetLesserPotency(AlchemicalBombSeeder seeder);
        protected abstract AlchemicalBombPotencyBinding GetModeratePotency(AlchemicalBombSeeder seeder);
        protected abstract AlchemicalBombPotencyBinding GetGreaterPotency(AlchemicalBombSeeder seeder);
        protected abstract AlchemicalBombPotencyBinding GetMajorPotency(AlchemicalBombSeeder seeder);
    }
}
