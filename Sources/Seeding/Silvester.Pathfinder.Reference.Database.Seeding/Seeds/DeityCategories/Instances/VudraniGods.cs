using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class VudraniGods : Template
    {
        public static readonly Guid ID = Guid.Parse("9071aac4-ebdd-45a5-ba88-e4af3c56d111");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Vudrani Gods", 
                Description = "No official description was provided." 
            };
        }
    }
}
