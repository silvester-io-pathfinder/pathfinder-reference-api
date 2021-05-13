using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder150 : Template
    {
        public static readonly Guid ID = Guid.Parse("5abe6c7b-5ca5-481f-bf05-76c1496631d0");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #150: Broken Promises"
            };
        }
    }
}
