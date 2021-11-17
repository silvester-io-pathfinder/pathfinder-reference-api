using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class TwelveBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("03892ea6-b07b-4163-b29e-7248aa872bba");

        protected override Bulk GetBulk()
        {
            return new Bulk 
            {
                Id = ID, 
                Name = "12", 
                BulkWeight = 12, 
                LightWeight = 0 
            };
        }
    }
}
