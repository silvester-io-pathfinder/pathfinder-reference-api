using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class DesertElf : Template
    {
        public static readonly Guid ID = Guid.Parse("4b699d38-c3fc-487c-a55b-f8d561897305");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Desert Elf", 
                Description = "You live under the desert’s blazing heat, gaining incredible resilience to warm environments. You gain fire resistance equal to half your level (minimum 1), and environmental heat effects are one step less extreme for you (incredible heat becomes extreme, extreme heat becomes severe, and so on)." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Elf.ID;
        }
    }
}
