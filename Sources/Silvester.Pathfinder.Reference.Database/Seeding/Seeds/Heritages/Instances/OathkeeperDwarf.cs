using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class OathkeeperDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("88f9765e-66ed-4780-bb53-c23c27b4f8ad");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Oathkeeper Dwarf", 
                Description = "Growing up, you never tried to lie to get what you wanted, and even when necessary, lying makes you uncomfortable. The especially faithful might even have thought that you were blessed by the dwarven god of duty, Kols. You gain a +1 circumstance bonus to Perception checks to Sense Motive and to Perception DCs against attempts to Lie to you. Furthermore, you gain a +2 circumstance bonus to Diplomacy checks to convince others you speak the truth when you are telling the truth, and you take a –4 circumstance penalty to Lie and to your Deception DC against Sense Motive." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Dwarf.ID;
        }
    }
}
