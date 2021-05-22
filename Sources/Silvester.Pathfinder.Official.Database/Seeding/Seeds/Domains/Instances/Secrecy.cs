using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Secrecy : Template
    {
        public static readonly Guid ID = Guid.Parse("433f01f4-387d-4cb7-b327-2b63bf21c16c");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Secrecy", 
                Description = "You protect secrets and keep them hidden." 
            };
        }
    }
}
