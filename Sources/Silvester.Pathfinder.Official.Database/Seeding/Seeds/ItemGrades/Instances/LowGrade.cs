using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemGrades.Instances
{
    public class LowGrade : Template
    {
        public static readonly Guid ID = Guid.Parse("496e2717-f62b-4212-a206-39ac5ccf9c96");

        public override ItemGrade GetGrade()
        {
            return new ItemGrade
            {
                Id = ID,
                Name = "Low Grade",
                Order = 0
            };
        }
    }
}
