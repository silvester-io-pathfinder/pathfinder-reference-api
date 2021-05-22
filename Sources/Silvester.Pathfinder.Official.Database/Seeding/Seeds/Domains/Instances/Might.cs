using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Might : Template
    {
        public static readonly Guid ID = Guid.Parse("3eb1a047-7ae9-481b-a9ab-675684b2a67e");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Might", 
                Description = "Your physical power is bolstered by divine strength." 
            };
        }
    }
}
