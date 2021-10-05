using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class CompanionItems : Template
    {
        public static readonly Guid ID = Guid.Parse("60022ff2-b13c-4a74-a82f-a084b5b9f44e");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 604, 
                Name = "Companion Items", 
                Description = "A category of worn items meant for animal companions and mounts." 
            };
        }
    }
}
