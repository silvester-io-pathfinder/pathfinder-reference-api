using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceRarities.Instances
{
    public class Rare : AbstractRarityTemplate
    {
        public static readonly Guid ID = Guid.Parse("863d10bd-583b-41e9-ae52-2d94cf0a2bff");

        protected override Rarity GetRaceRarity(RaritySeeder seeder)
        {
            return new Rarity
            {
                Id = ID,
                Name = "Rare"
            };
        }
    }
}
