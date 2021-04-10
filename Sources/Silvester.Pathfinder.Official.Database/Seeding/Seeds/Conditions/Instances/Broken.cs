using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Broken : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("8ecb38b2-d7fb-440f-b096-cf381652b2ff");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Broken",
                Description = "Broken is a condition that affects objects. An object is broken when damage has reduced its Hit Points to equal or less than its Broken Threshold. A broken object can't be used for its normal function, nor does it grant bonuses— with the exception of armor. Broken armor still grants its item bonus to AC, but it also imparts a status penalty to AC depending on its category: –1 for broken light armor, –2 for broken medium armor, or –3 for broken heavy armor.  A broken item still imposes penalties and limitations normally incurred by carrying, holding, or wearing it. For example, broken armor would still impose its Dexterity modifier cap, check penalty, and so forth.  If an effect makes an item broken automatically and the item has more HP than its Broken Threshold, that effect also reduces the item's current HP to the Broken Threshold."
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("535f3f02-9a6f-4b34-9080-460f626a969c"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 618
            };
        }
    }
}
