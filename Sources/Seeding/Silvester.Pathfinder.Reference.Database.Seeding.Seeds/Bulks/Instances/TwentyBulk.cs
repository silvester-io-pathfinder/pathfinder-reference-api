using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class TwentyBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("05263283-3da9-4337-bdd8-a0c7416bd4d3");

        protected override Bulk GetBulk()
        {
            return new Bulk 
            {
                Id = ID, 
                Name = "20", 
                BulkWeight = 20, 
                LightWeight = 0 
            };
        }
    }
}
