using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances
{
    public class TwoBulk : AbstractBulkTemplate
    {
        public static readonly Guid ID = Guid.Parse("28310eb8-9bee-46f0-9b93-e0965207169a");

        protected override Bulk GetBulk()
        {
            return new Bulk 
            {
                Id = ID, 
                Name = "2", 
                BulkWeight = 2, 
                LightWeight = 0 
            };
        }
    }
}
