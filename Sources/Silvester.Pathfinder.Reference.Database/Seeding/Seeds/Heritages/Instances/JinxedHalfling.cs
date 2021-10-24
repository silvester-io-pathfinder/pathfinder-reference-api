using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class JinxedHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("c2c39377-feae-4142-a4c9-6d0e458d355c");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Jinxed Halfling", 
                Description = "You were born with a strange blessing: bereft of the typical halfling luck, you can instead manipulate the fortunes of others. You can never take the Halfling Luck feat, and you gain the Jinx action." 
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Halfling.ID;
        }
    }
}
