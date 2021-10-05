using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class FortyBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("1d6e5065-19b2-44fc-8f72-c6f2f801b3be");

        protected override Bulk GetBulk()
        {
            return new Bulk 
            {
                Id = ID, 
                Name = "40", 
                BulkWeight = 40, 
                LightWeight = 0 
            };
        }
    }
}
