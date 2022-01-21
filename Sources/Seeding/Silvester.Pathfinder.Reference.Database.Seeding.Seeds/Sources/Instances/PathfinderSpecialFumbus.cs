using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class PathfinderSpecialFumbus : Template
    {
        public static readonly Guid ID = Guid.Parse("568d98fb-b098-4a88-be7e-048d476fcf84");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder Special: Fumbus"
            };
        }
    }
}
