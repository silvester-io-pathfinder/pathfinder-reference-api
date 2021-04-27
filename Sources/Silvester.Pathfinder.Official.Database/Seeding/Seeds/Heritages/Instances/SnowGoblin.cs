using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class SnowGoblin : AbstractHeritageTemplate
    {
        public static readonly Guid ID = Guid.Parse("e6c22bc6-bb97-480b-85c3-6d1b2dd3980a");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Snow Goblin", 
                Description = "You are acclimated to living in frigid lands and have skin ranging from sky blue to navy in color, as well as blue fur. You gain cold resistance equal to half your level (minimum 1). You treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on)." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Goblin.ID;
        }
    }
}
