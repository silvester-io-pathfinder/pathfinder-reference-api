using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialItemCategories.Instances
{
    public class ThinItems : Template
    {
        public static Guid ID = Guid.Parse("2b41e291-636f-408d-9b2f-308f703f5931");

        public override PreciousMaterialItemCategory GetCategory()
        {
            return new  PreciousMaterialItemCategory   
            {
                Id = ID,
                Name = "Thin Items"
            };
        }
    }
}
