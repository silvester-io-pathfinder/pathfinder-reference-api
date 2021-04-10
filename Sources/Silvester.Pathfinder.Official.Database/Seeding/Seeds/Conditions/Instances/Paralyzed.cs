using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances
{
    public class Paralyzed : AbstractConditionTemplate
    {
        public static readonly Guid ID = Guid.Parse("5007c3b2-b184-43b1-85d7-ad159d14ccb5");

        public override Condition GetCondition(ConditionSeeder seeder)
        {
            return new Condition
            {
                Id = ID,
                Name = "Paralyzed",
                Description = "Your body is frozen in place. You have the flat-footed condition and can't act except to Recall Knowledge and use actions that require only the use of your mind (as determined by the GM). Your senses still function, but only in the areas you can perceive without moving your body, so you can't Seek while paralyzed.",
            };
        }

        public override SourcePage? GetSourcePage(ConditionSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("17810441-9218-4e9d-a962-1e7697516b2d"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 621
            };
        }
    }
}
