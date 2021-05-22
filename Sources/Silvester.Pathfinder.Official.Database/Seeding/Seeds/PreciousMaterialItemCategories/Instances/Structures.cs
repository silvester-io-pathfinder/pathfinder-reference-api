using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialItemCategories.Instances
{
    public class Structures : Template
    {
        public static Guid ID = Guid.Parse("5fd28296-37aa-4b5a-ab4c-806dddfce3ba");

        public override PreciousMaterialItemCategory GetCategory()
        {
            return new  PreciousMaterialItemCategory   
            {
                Id = ID,
                Name = "Structures"
            };
        }
    }
}
