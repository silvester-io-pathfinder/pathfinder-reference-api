using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Air : Template
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
