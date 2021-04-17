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
                bomb.SourcePageId = sourcePage.Id;
            }

            foreach (AlchemicalBombDetailBlock detailBlock in GetDetailBlocks())
            {
                detailBlock.AlchemicalBombId = bomb.Id;
                seeder.Builder.AddData(detailBlock);
            }

            foreach (AlchemicalBombPotencyBinding potency in GetPotencies(seeder))
            {
                potency.AlchemicalBombId = bomb.Id;
                seeder.Builder.AddData(potency);
            }

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((bomb, trait));
            }

            seeder.Builder.AddData(bomb);
        }

        protected abstract AlchemicalBomb GetAlchemicalBomb(AlchemicalBombSeeder seeder);
        protected abstract SourcePage? GetSourcePage(AlchemicalBombSeeder seeder);
        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<AlchemicalBombDetailBlock> GetDetailBlocks();
        protected abstract IEnumerable<AlchemicalBombPotencyBinding> GetPotencies(AlchemicalBombSeeder seeder);
    }
}
