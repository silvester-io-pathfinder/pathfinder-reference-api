using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Ambition : Template
    {
        public static readonly Guid ID = Guid.Parse("78d1b6a0-7f67-4e3c-a25c-dbf4aa4cd838");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Ambition", 
                Description = "You strive to keep up with and outpace the competition." 
            };
        }
    }
}
