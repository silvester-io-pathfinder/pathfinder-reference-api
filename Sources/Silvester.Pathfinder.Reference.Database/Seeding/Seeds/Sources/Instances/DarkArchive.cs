using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class DarkArchive : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
