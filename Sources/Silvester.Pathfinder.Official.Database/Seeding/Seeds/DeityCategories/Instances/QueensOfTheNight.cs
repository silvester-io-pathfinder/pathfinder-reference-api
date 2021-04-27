using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class QueensOfTheNight : AbstractDeityCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("cb6ebc9d-9a0e-4d7c-9a7d-d5da7ea043bd");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            {
                Id = ID,
                Name = "Queens of the Night", 
                Description = "The Queens of the Night have won their own measure of power in Hell." 
            };
        }
    }
}
