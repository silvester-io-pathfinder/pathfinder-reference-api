using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class GodsAndMagic : AbstractSourceTemplate
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
