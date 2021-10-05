using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class CharhideGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("b5615a58-0fc5-4b2d-87b7-b3f2e74e3a10");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Charhide Goblin", 
                Description = "Your ancestors have always had a connection to fire and a thicker skin, which allows you to resist burning. You gain fire resistance equal to half your level (minimum 1). You can also recover from being on fire more easily. Your flat check to remove persistent fire damage is DC 10 instead of DC 15, which is reduced to DC 5 if another creature uses a particularly appropriate action to help." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Goblin.ID;
        }
    }
}
