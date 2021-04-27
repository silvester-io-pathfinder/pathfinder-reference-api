using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Bestiary : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("2e2cec6f-d049-4c83-b018-86123f6dd183");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Bestiary"
            };
        }
    }
}
