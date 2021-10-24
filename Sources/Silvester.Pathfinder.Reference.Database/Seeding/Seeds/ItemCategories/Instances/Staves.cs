using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Staves : Template
    {
        public static readonly Guid ID = Guid.Parse("64a4ddc3-6da3-475e-a65c-dafc742dfea7");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 592, 
                Name = "Staves", 
                Description = "Provide flexible spellcasting options." 
            };
        }
    }
}
