using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Confidence : Template
    {
        public static readonly Guid ID = Guid.Parse("3020bd98-a4f8-4e92-9c92-58110679137f");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Confidence", 
                Description = "You overcome your fear and project pride." 
            };
        }
    }
}
