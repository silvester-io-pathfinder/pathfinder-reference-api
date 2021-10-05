using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class RockDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("b9e766b7-d4e6-4f93-bc21-8020c2cc09bc");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Rock Dwarf", 
                Description = "Your ancestors lived and worked among the great ancient stones of the mountains or the depths of the earth. This makes you solid as a rock when you plant your feet. You gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to Shove or Trip you. This bonus also applies to saving throws against spells or effects that attempt to knock you prone. In addition, if any effect would force you to move 10 feet or more, you are moved only half the distance." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Dwarf.ID;
        }
    }
}
