using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Magic : Template
    {
        public static readonly Guid ID = Guid.Parse("9eadaa7c-bb04-4017-a31c-77a5355e0d2c");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Magic", 
                Description = "You perform the unexpected and inexplicable." 
            };
        }
    }
}
