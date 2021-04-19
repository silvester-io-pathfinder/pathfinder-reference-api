using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceRarities.Instances
{
    public class Common : AbstractRarityTemplate
    {
        public static readonly Guid ID = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792");

        protected override Rarity GetRaceRarity(RaritySeeder seeder)
        {
            return new Rarity
            {
                Id = ID,
                Name = "Common"
            };
        }
    }
}
