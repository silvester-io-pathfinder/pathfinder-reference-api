using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class PathfinderBeginnerBoxHerosHandbook : Template
    {
        public static readonly Guid ID = Guid.Parse("237d34c4-a4da-45f2-8e46-3d376d9e49ff");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder Beginner Box: Hero's Handbook"
            };
        }
    }
}
