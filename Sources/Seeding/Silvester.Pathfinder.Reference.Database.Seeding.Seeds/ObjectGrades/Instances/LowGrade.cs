using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ObjectGrades.Instances
{
    public class LowGrade : Template
    {
        public static readonly Guid ID = Guid.Parse("496e2717-f62b-4212-a206-39ac5ccf9c96");

        public override ObjectGrade GetGrade()
        {
            return new ObjectGrade
            {
                Id = ID,
                Name = "Low Grade",
                Order = 0
            };
        }
    }
}
