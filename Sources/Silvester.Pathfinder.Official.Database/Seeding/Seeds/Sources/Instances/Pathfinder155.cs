using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder155 : AbstractSourceTemplate
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
