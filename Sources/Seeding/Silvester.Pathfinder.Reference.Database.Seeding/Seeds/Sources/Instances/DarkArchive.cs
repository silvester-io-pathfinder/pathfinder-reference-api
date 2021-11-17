using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class DarkArchive : Template
    {
        public static readonly Guid ID = Guid.Parse("42b201a5-4d3a-49fe-9959-007586e8d59a");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Dark Archive"
            };
        }
    }
}
