using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class GunsAndGears : Template
    {
        public static readonly Guid ID = Guid.Parse("94dbd874-2d3c-46ca-9c78-f1af80d6c364");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Guns & Gears"
            };
        }
    }
}
