using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances
{
    public class NegligibleBulk : AbstractBulkTemplate
    {
        public static readonly Guid ID = Guid.Parse("b5de3410-d051-4dfe-be54-dde62ee45bc1");

        protected override Bulk GetBulk()
        {
            return new Bulk 
            {
                Id = ID, 
                Name = "-", 
                BulkWeight = 0, 
                LightWeight = 0 
            };
        }
    }
}
