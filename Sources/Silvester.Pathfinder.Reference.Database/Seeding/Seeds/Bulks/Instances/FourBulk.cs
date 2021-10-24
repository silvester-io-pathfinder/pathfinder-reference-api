using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class FourBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("61e784de-dd93-4d53-acda-61dff663e2a3");
        
        protected override Bulk GetBulk()
        {
            return new Bulk
            {
                Id = ID, 
                Name = "4", 
                BulkWeight = 4, 
                LightWeight = 0 
            };
        }
    }
}
