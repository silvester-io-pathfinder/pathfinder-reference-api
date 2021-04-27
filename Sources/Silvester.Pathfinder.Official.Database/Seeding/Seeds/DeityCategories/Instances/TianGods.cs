using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class TianGods : AbstractDeityCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("60738a86-c7af-4b79-b29c-a0e861a08da4");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID,
                Name = "Tian Gods", 
                Description = "No official description was provided." 
            };
        }
    }
}
