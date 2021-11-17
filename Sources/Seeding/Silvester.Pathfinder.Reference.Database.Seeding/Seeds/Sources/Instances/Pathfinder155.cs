using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder155 : Template
    {
        public static readonly Guid ID = Guid.Parse("e4f9b68a-f157-4657-bb05-0b50d1e5b955");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #155: Lord of the Black Sands"
            };
        }
    }
}
