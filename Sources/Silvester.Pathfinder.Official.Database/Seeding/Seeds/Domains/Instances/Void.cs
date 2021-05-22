using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Void : Template
    {
        public static readonly Guid ID = Guid.Parse("611f0345-55bd-4632-9bfc-b10a5cf64491");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Void", 
                Description = "You draw power from emptiness." 
            };
        }
    }
}
