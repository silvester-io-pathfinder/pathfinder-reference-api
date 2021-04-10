using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Encumbered : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("5da2ad79-54a0-429e-a52a-d654841fb268");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Encumbered",
                Description = "You are carrying more weight than you can manage. While you’re encumbered, you’re clumsy 1 and take a 10-foot penalty to all your Speeds. As with all penalties to your Speed, this can’t reduce your Speed below 5 feet."
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ca1a968-dcb9-4353-b15e-e397cda35b48"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 619
            };
        }
    }
}
