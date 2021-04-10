using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Carrier : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("d1a95821-ef2b-4c73-8ec6-9ec6789c885d");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Carrier",
                Description = "You are the carrier of a disease, but you do not yet experience symptoms.",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return null;
        }
    }
}
