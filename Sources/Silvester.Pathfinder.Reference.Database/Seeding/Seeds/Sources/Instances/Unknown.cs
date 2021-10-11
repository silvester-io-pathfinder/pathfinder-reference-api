using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Unknown : Template
    {
        public static readonly Guid ID = Guid.Parse("99440d6d-f8d2-40d2-abc3-e628827286ec");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Unknown"
            };
        }
    }
}
