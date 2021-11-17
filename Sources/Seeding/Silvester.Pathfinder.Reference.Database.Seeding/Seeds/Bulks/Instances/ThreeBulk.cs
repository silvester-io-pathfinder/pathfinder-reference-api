using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class ThreeBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("d09af7fc-06b3-41c5-89f7-7cbb3fb6f93b");

        protected override Bulk GetBulk()
        {
            return new Bulk 
            {
                Id = ID, 
                Name = "3", 
                BulkWeight = 3, 
                LightWeight = 0 
            };
        }
    }
}
