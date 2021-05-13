using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class OtherGods : Template
    {
        public static readonly Guid ID = Guid.Parse("d4f49f9c-0107-478c-9d21-c9c5214e76bb");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID,
                Name = "Other Gods", 
                Description = "These deities are not quite as widely worshiped as the 20 primary deities of the Inner Sea region, though they grant their worshippers just as much power and are just as important in their worshippers' lives." 
            };
        }
    }
}
