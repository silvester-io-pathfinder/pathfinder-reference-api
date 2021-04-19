using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes
{
    public abstract class AbstractRaceSizeTemplate
    {
        public void Seed(RaceSizeSeeder seeder)
        {
            RaceSize size = GetRaceSize(seeder);
            seeder.Builder.AddData(size);
        }

        protected abstract RaceSize GetRaceSize(RaceSizeSeeder seeder);
    }
}
