using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class Archdevils : Template
    {
        public static readonly Guid ID = Guid.Parse("dd52c19b-ce83-4e46-ae17-6560d42c8c1a");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID,
                Name = "Archdevils", 
                Description = "Each archdevil holds uncontested rule over one of the first eight realms of Hell." 
            };
        }
    }
}
