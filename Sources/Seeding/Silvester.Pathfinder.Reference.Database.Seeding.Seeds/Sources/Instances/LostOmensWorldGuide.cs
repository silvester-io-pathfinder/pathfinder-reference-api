using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class LostOmensWorldGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("ad491763-2c2d-4a71-a22d-c73dfad0e4c3");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Lost Omens - World Guide"
            };
        }
    }
}
