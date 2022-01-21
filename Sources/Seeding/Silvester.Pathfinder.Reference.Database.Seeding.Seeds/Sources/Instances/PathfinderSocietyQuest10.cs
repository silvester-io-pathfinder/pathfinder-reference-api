using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class PathfinderSocietyQuest10 : Template
    {
        public static readonly Guid ID = Guid.Parse("a41abc81-a767-4af6-b231-cc31658deb37");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder Society Quest #10: The Broken Scales"
            };
        }
    }
}
