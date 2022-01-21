using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class OneBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("8ad6f1e7-1ac2-47fd-b374-bb4f077a2545");

        protected override Bulk GetBulk()
        {
            return new Bulk
            {
                Id = ID, 
                Name = "1", 
                BulkWeight = 1, 
                LightWeight = 0 
            };
        }
    }
}
