using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Luck : AbstractDomainTemplate
    {
        public static readonly Guid ID = Guid.Parse("87a70253-a298-467a-92e1-a3be315e34b0");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Luck", 
                Description = "You’re unnaturally lucky and keep out of harm’s way." 
            };
        }
    }
}
