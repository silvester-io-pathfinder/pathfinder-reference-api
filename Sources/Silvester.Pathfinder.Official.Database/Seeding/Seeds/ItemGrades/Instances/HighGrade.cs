using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemGrades.Instances
{
    public class HighGrade : Template
    {
        public static readonly Guid ID = Guid.Parse("02030f72-6fdd-43e9-aef8-98d53c47a6c8");

        public override ItemGrade GetGrade()
        {
            return new ItemGrade
            {
                Id = ID,
                Name = "High Grade",
                Order = 2
            };
        }
    }
}
