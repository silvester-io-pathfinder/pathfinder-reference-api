using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceRarities.Instances
{
    public class Uncommon : AbstractRarityTemplate
    {
        public static readonly Guid ID = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0");

        protected override Rarity GetRaceRarity(RaritySeeder seeder)
        {
            return new Rarity
            {
                Id = ID,
                Name = "Uncommon"
            };
        }
    }
}
