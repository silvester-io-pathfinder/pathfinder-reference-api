using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class OldSunGods : Template
    {
        public static readonly Guid ID = Guid.Parse("1a209857-903b-4a88-9c42-bfcaf5f7b053");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory
            {
                Id = ID,
                Name = "Old Sun Gods",
                Description = "Although once mostly forgotten, the Old Sun Gods have slowly been brought back to the people of Mzali thanks to Sihar and the Bright Lions."
            };
        }
    }
}
