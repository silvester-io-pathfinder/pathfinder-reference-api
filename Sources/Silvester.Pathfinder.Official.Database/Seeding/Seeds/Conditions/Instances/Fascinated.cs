using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Fascinated : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("33b600ff-067e-4a67-a1ce-c85cf2d2382c");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Fascinated",
                Description = "You are compelled to focus your attention on something, distracting you from whatever else is going on around you. You take a –2 status penalty to Perception and skill checks, and you can't use actions with the concentrate trait unless they or their intended consequences are related to the subject of your fascination (as determined by the GM). For instance, you might be able to Seek and Recall Knowledge about the subject, but you likely couldn't cast a spell targeting a different creature. This condition ends if a creature uses hostile actions against you or any of your allies."
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("1dbef0bc-4ffe-4e45-964f-83bbad2c884d"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 619
            };
        }
    }
}
