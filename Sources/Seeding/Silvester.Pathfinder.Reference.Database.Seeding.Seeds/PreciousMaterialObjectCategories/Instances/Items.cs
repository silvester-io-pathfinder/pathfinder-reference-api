using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialObjectCategories.Instances
{
    public class Items : Template
    {
        public static Guid ID = Guid.Parse("ddd6cc28-1827-4e8c-afa6-c60b004b6056");

        public override PreciousMaterialObjectCategory GetCategory()
        {
            return new PreciousMaterialObjectCategory
            {
                Id = ID,
                Name = "Items"
            };
        }
    }
}
