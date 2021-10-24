using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Soul : Template
    {
        public static readonly Guid ID = Guid.Parse("175bf44e-7909-46eb-b135-a7e97297d8df");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Soul", 
                Description = "You wield power over the spiritual.." 
            };
        }
    }
}
