using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Runes : Template
    {
        public static readonly Guid ID = Guid.Parse("8a494ffa-3f11-4e4e-9373-b376942fc75d");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 580, 
                Name = "Runes", 
                Description = "Modify armor and weapons when etched onto them. This section includes fundamental runes for weapons (weapon potency and striking) and armor (armor potency and resilient)." 
            };
        }
    }
}
