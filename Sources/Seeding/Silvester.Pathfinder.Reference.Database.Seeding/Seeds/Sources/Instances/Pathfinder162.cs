using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder162 : Template
    {
        public static readonly Guid ID = Guid.Parse("bc39a699-fa13-4adb-a424-4fef5ae79b40");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #162: Kingmaker"
            };
        }
    }
}
