using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Shields : Template
    {
        public static readonly Guid ID = Guid.Parse("eed4990e-e635-4683-a920-1937bf9736f2");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 586, 
                Name = "Shields", 
                Description = "More durable shields and ones with special magical powers." 
            };
        }
    }
}
