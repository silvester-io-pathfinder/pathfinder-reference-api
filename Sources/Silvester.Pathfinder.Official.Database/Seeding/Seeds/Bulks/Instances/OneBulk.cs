using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances
{
    public class OneBulk : AbstractBulkTemplate
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
