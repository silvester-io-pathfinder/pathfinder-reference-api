using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Knowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("a434a214-22db-4d03-bd31-d2af7f4c4f76");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Knowledge", 
                Description = "You receive divine insights." 
            };
        }
    }
}
