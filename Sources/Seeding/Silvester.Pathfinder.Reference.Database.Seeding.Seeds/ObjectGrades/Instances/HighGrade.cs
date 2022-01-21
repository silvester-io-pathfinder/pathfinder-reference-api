using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ObjectGrades.Instances
{
    public class HighGrade : Template
    {
        public static readonly Guid ID = Guid.Parse("02030f72-6fdd-43e9-aef8-98d53c47a6c8");

        public override ObjectGrade GetGrade()
        {
            return new ObjectGrade
            {
                Id = ID,
                Name = "High Grade",
                Order = 2
            };
        }
    }
}
