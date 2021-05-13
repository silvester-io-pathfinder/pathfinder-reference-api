using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Earth : Template
    {
        public static readonly Guid ID = Guid.Parse("41f79fe2-6ac6-42ec-a69c-15046cd962f4");

        protected override Domain GetDomain()
        {
           return new Domain 
           {
               Id = ID, 
               Name = "Earth", 
               Description = "You control soil and stone." 
           };
        }
    }
}
