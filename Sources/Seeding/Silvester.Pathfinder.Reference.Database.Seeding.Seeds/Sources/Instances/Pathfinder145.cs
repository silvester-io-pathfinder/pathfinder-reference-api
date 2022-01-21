using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder145 : Template
    {
        public static readonly Guid ID = Guid.Parse("7468b780-cb6d-4bdc-a456-3977b1f43410");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #145: Hellknight Hill"
            };
        }
    }
}
