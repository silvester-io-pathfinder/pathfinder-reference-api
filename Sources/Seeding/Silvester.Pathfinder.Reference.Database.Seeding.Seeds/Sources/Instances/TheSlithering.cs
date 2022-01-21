using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class TheSlithering : Template
    {
        public static readonly Guid ID = Guid.Parse("5a6f4a9c-5156-420a-85e7-73ddd42acb15");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "The Slithering"
            };
        }
    }
}
