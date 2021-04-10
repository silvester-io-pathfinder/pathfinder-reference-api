using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Choked : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("9c93e839-3ea9-4baa-aada-951d8fbf9807");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Choked",
                Description = "You are choked, either physically by something or someone, by something magical, or by the the effects of a disease or illness (such as coughing). You need to pass a flat DC check equal to the severity of the condition when you attempt to cast a spell that has a verbal component to it, or activate an item that has a command component to it.",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return null; ;
        }
    }
}
