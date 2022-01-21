using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Bestiary : Template
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
