using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class AncientBloodedDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("4023db86-7064-4ad0-936e-e1f5c95e921b");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Ancient-Blooded Dwarf", 
                Description = "Dwarven heroes of old could shrug off their enemies’ magic, and some of that resistance manifests in you. You gain the Call on Ancient Blood reaction." 
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Dwarf.ID;
        }
    }
}
