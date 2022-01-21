using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class GrandBazaar : Template
    {
        public static readonly Guid ID = Guid.Parse("ea2f8b44-1914-48b8-8d14-f0d996e35246");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Grand Bazaar"
            };
        }
    }
}
