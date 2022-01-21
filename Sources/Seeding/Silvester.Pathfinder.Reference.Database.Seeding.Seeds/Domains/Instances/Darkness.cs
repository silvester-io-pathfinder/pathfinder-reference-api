using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Darkness : Template
    {
        public static readonly Guid ID = Guid.Parse("c750af99-1697-4c06-abb1-cb91bc2f8099");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Darkness", 
                Description = "You operate in the darkness and take away the light." 
            };
        }
    }
}
