using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Consumables : Template
    {
        public static readonly Guid ID = Guid.Parse("14299b81-a8c5-4136-b230-ecbb7653a150");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 559, 
                Name = "Consumables", 
                Description = "Used up when you activate them, and include ammunition, oils, potions, scrolls, and talismans, among others. Categories of items that are consumables but have specific rules, such as alchemical items, are presented separately." 
            };
        }
    }
}
