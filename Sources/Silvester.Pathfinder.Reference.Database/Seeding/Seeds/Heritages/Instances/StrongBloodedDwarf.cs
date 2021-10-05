using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class StrongBloodedDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("635245e9-3230-4dab-8b0b-fac29a761c37");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Strong-Blooded Dwarf", 
                Description = "Your blood runs hearty and strong, and you can shake off toxins. You gain poison resistance equal to half your level (minimum 1), and each of your successful saving throws against a poison affliction reduces its stage by 2, or by 1 for a virulent poison. Each critical success against an ongoing poison reduces its stage by 3, or by 2 for a virulent poison." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Dwarf.ID;
        }
    }
}
