using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Passion : Template
    {
        public static readonly Guid ID = Guid.Parse("e3128860-aa47-47ac-a090-8252e83cec96");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Passion", 
                Description = "You evoke passion, whether as love or lust." 
            };
        }
    }
}
