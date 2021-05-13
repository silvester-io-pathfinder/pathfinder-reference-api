using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialItemCategories.Instances
{
    public class Items : Template
    {
        public static Guid ID = Guid.Parse("ddd6cc28-1827-4e8c-afa6-c60b004b6056");

        public override PreciousMaterialItemCategory GetCategory()
        {
            return new  PreciousMaterialItemCategory   
            {
                Id = ID,
                Name = "Items"
            };
        }
    }
}
