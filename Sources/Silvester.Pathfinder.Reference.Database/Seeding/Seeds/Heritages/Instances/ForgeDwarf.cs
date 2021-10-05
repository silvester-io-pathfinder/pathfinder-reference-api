using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ForgeDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("541986ae-7349-44fd-8004-c2e606e4f140");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Forge Dwarf", 
                Description = "You have a remarkable adaptation to hot environments from ancestors who inhabited blazing deserts or volcanic chambers beneath the earth. This grants you fire resistance equal to half your level (minimum 1), and you treat environmental heat effects as if they were one step less extreme (incredible heat becomes extreme, extreme heat becomes severe, and so on)." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Dwarf.ID;
        }
    }
}
