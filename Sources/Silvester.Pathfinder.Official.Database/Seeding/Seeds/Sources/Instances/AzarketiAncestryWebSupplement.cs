using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class AzarketiAncestryWebSupplement : Template
    {
        public static readonly Guid ID = Guid.Parse("aa26c82c-86d4-49f3-9fc9-53022c6c9ca8");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Azarketi Ancestry Web Supplement"
            };
        }
    }
}
