using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class AncestryGuide : Template
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
