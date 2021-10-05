using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class TheFallOfPlaguestone : Template
    {
        public static readonly Guid ID = Guid.Parse("c0123df3-d59f-4a25-b531-00d84438e907");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "The Fall of Plaguestone"
            };
        }
    }
}
