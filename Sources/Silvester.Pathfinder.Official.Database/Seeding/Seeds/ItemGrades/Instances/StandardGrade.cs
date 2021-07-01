using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemGrades.Instances
{
    public class StandardGrade : Template
    {
        public static readonly Guid ID = Guid.Parse("c025717b-a893-46cf-8843-7c541339127e");

        public override ItemGrade GetGrade()
        {
            return new ItemGrade
            {
                Id = ID,
                Name = "Standard Grade",
                Order = 1
            };
        }
    }
}
