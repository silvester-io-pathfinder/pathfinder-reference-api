using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Truth : Template
    {
        public static readonly Guid ID = Guid.Parse("833f560a-af75-49c8-8da6-d4e15a6a18a0");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Truth", 
                Description = "You pierce lies and discover the truth." 
            };
        }
    }
}
