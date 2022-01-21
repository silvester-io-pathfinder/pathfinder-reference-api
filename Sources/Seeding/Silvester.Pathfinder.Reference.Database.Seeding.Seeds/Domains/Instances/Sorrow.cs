using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Sorrow : Template
    {
        public static readonly Guid ID = Guid.Parse("cbf2d04b-6ef2-4530-a1c7-2ab3b9abaa31");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Sorrow", 
                Description = "You have a painful connection to melancholy and sadness."
            };
        }
    }
}
