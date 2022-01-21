using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class FiveBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("bae8a954-7dcb-4402-af91-938ece15a8ef");
        
        protected override Bulk GetBulk()
        {
            return new Bulk
            {
                Id = ID, 
                Name = "5", 
                BulkWeight = 5, 
                LightWeight = 0 
            };
        }
    }
}
