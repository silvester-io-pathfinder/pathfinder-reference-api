using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Tyranny : Template
    {
        public static readonly Guid ID = Guid.Parse("3c78a88a-9b78-4dc7-8f97-231a5788714e");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Tyranny", 
                Description = "You wield power to rule and enslave others." 
            };
        }
    }
}
