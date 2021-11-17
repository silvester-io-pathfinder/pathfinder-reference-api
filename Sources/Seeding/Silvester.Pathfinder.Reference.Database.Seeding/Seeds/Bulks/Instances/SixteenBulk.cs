using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class SixteenBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("bcd4ffa2-a04b-4a74-ae12-c839667caa71");
        
        protected override Bulk GetBulk()
        {
            return new Bulk
            {
                Id = ID, 
                Name = "16", 
                BulkWeight = 16, 
                LightWeight = 0 
            };
        }
    }
}
