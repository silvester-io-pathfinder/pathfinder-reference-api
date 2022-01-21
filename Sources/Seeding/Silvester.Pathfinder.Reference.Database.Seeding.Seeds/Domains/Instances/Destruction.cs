using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Destruction : Template
    {
        public static readonly Guid ID = Guid.Parse("2805fab3-bfb6-4192-9ffe-4a7983faa016");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Destruction", 
                Description = "You are a conduit for divine devastation."
            };
        }
    }
}
