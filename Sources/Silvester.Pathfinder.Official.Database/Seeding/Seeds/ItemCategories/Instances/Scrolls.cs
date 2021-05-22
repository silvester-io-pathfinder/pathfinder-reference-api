using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Scrolls : Template
    {
        public static readonly Guid ID = Guid.Parse("44429e3b-ba5c-4733-826b-2a21758ebfca");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 564, 
                Name = "Scrolls", 
                Description = "Consumables that allow spellcasters to cast more spells." 
            };
        }
    }
}
