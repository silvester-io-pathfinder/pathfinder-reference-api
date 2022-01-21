using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ObjectGrades.Instances
{
    public class StandardGrade : Template
    {
        public static readonly Guid ID = Guid.Parse("c025717b-a893-46cf-8843-7c541339127e");

        public override ObjectGrade GetGrade()
        {
            return new ObjectGrade
            {
                Id = ID,
                Name = "Standard Grade",
                Order = 1
            };
        }
    }
}
