using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Trickery : Template
    {
        public static readonly Guid ID = Guid.Parse("ce60c9f8-e9a7-42e2-87e5-5d7e5210dbfa");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Trickery", 
                Description = "You deceive others and cause mischief." 
            };
        }
    }
}
