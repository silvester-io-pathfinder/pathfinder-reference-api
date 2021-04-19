using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceRarities
{
    public abstract class AbstractRarityTemplate
    {
        public void Seed(RaritySeeder seeder)
        {
            Rarity rarity = GetRaceRarity(seeder);
            seeder.Builder.AddData(rarity);
        }

        protected abstract Rarity GetRaceRarity(RaritySeeder seeder);
    }
}
