using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Bestiary3 : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("0b807fe4-b914-43d8-a7e1-bcd68226e39c");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Bestiary 3"
            };
        }
    }
}
