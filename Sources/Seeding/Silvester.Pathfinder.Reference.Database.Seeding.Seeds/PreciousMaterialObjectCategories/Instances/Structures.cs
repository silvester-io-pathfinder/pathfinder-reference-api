using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialObjectCategories.Instances
{
    public class Structures : Template
    {
        public static Guid ID = Guid.Parse("5fd28296-37aa-4b5a-ab4c-806dddfce3ba");

        public override PreciousMaterialObjectCategory GetCategory()
        {
            return new PreciousMaterialObjectCategory
            {
                Id = ID,
                Name = "Structures"
            };
        }
    }
}
