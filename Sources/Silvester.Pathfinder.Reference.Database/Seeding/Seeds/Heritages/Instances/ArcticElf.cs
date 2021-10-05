using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ArcticElf : Template
    {
        public static readonly Guid ID = Guid.Parse("62d5db67-945b-4cea-971f-9a2fa5038f2d");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Arctic Elf", 
                Description = "You dwell deep in the frozen north and have gained incredible resilience against cold environments, granting you cold resistance equal to half your level (minimum 1). You treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on)." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Elf.ID;
        }
    }
}
