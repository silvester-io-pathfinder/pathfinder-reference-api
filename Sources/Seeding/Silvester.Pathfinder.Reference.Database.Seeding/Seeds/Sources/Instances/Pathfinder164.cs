using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder164 : Template
    {
        public static readonly Guid ID = Guid.Parse("a787e8a6-a6ec-4ced-b797-6a41d08920c9");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #164: Hands of the Devil"
            };
        }
    }
}
