using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class HalfOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("b54692a4-5791-4971-9590-17889ca0cbaa");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Half-Orc", 
                Description = "One of your parents was an orc, or one or both were half-orcs. You have a green tinge to your skin and other indicators of orc heritage. You gain the orc trait, the half-orc trait, and low-light vision. In addition, you can select orc, half-orc, and human feats whenever you gain an ancestry feat." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Human.ID;
            yield return Orc.ID;
        }
    }
}
