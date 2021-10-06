using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class IrongutGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("d1269abf-7396-4b72-8130-9a74f3253bfb");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Irongut Goblin", 
                Description = "You can subsist on food that most folks would consider spoiled. You can keep yourself fed with poor meals in a settlement as long as garbage is readily available, without using the Subsist downtime activity. You can eat and drink things when you are sickened. You gain a + 2 circumstance bonus to saving throws against afflictions, against gaining the sickened condition, and to remove the sickened condition.When you roll a success on a Fortitude save affected by this bonus, you get a critical success instead.All these benefits apply only when the affliction or condition resulted from something you ingested." 
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Goblin.ID;
        }
    }
}
