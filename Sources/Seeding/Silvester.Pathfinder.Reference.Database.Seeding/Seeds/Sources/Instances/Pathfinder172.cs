using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder172 : Template
    {
        public static readonly Guid ID = Guid.Parse("a3d56bdd-bcb8-46e0-9f07-c7e9b98e96f0");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #172: Secrets of the Temple-City"
            };
        }
    }
}
