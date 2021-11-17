using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class PathfinderSocietyGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("b28880b6-eeab-4222-a54c-1a2a5e3f27d8");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder Society Guide"
            };
        }
    }
}
