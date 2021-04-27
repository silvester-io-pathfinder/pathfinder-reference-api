using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Air : AbstractDomainTemplate
    {
        public static readonly Guid ID = Guid.Parse("09797fbb-48b5-42fa-abf3-5468c06dbbce");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Air", 
                Description = "You can control winds and the weather." 
            };
        }
    }
}
