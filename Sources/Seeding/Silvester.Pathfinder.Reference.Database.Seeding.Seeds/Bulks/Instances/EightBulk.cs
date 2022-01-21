using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances
{
    public class EightBulk : Template
    {
        public static readonly Guid ID = Guid.Parse("c4e48374-a6bb-43d4-863b-09cd9ac1fd6d");
        
        protected override Bulk GetBulk()
        {
            return new Bulk
            {
                Id = ID, 
                Name = "8", 
                BulkWeight = 8, 
                LightWeight = 0 
            };
        }
    }
}
