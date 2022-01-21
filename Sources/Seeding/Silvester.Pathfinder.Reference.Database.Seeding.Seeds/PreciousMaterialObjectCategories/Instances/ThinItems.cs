using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialObjectCategories.Instances
{
    public class ThinItems : Template
    {
        public static Guid ID = Guid.Parse("2b41e291-636f-408d-9b2f-308f703f5931");

        public override PreciousMaterialObjectCategory GetCategory()
        {
            return new PreciousMaterialObjectCategory
            {
                Id = ID,
                Name = "Thin Items"
            };
        }
    }
}
