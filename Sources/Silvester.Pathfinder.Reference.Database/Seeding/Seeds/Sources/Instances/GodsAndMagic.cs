using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class GodsAndMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("65d128a3-beaa-4d15-829c-5e82ebc3e9e6");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Gods and Magic"
            };
        }
    }
}
