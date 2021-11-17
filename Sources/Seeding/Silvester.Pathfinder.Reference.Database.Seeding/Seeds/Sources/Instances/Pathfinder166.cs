using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder166 : Template
    {
        public static readonly Guid ID = Guid.Parse("63c57c69-3867-46ad-aa99-2b030c42b531");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #166: Despair on Danger Island"
            };
        }
    }
}
