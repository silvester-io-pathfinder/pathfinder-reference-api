using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Cold : AbstractDomainTemplate
    {
        public static readonly Guid ID = Guid.Parse("eceea1c6-3be5-49dd-bfb4-fca321132069");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Cold", 
                Description = "You control ice, snow, and freezing temperatures." 
            };
        }
    }
}
