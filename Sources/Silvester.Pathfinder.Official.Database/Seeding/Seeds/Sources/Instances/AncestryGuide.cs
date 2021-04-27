using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class AncestryGuide : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("e11f405f-c6bf-4b1f-881e-2a69418ef4cd");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Ancestry Guide"
            };
        }
    }
}
