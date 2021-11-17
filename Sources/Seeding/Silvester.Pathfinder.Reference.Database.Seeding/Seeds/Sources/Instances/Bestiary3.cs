using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Bestiary3 : Template
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
