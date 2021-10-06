using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class AncientElf : Template
    {
        public static readonly Guid ID = Guid.Parse("c7209f66-ad64-4356-bf03-aeb4e94bbd6f");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Ancient Elf", 
                Description = "In your long life, you’ve dabbled in many paths and many styles. Choose a class other than your own. You gain the multiclass dedication feat for that class, even though you don’t meet its level prerequisite. You must still meet its other prerequisites to gain the feat." 
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Elf.ID;
        }
    }
}
