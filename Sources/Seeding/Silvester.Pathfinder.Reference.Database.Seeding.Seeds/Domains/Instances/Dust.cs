using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Dust : Template
    {
        public static readonly Guid ID = Guid.Parse("8869f3c0-8b7b-426b-bad6-896da2e02158");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Dust", 
                Description = "You have the power to dry and crumble what opposes you."
            };
        }
    }
}
