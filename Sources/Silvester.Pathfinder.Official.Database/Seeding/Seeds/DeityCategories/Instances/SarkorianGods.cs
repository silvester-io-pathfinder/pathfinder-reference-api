using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class SarkorianGods : Template
    {
        public static readonly Guid ID = Guid.Parse("aa2c5a37-9a30-4bdb-904e-ca1de189edbb");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Sarkorian Gods", 
                Description = "No official description was provided." 
            };
        }
    }
}
