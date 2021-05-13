using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class AncientOsirianGods : Template
    {
        public static readonly Guid ID = Guid.Parse("064c64d0-17be-4237-89b0-f04cf6e0fbfe");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            {
                Id = ID,
                Name = "Ancient Osirian Gods", 
                Description = " No official description was provided." 
            };
        }
    }
}
