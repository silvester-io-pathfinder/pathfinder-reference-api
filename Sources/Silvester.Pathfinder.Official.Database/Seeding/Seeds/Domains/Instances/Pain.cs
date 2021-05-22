using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Pain : Template
    {
        public static readonly Guid ID = Guid.Parse("526ee5b8-2123-45ea-9711-123252645561");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Pain", 
                Description = "You punish those who displease you with the sharp sting of pain." 
            };
        }
    }
}
