using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Perfection : Template
    {
        public static readonly Guid ID = Guid.Parse("8eb27986-a0a7-433c-90b0-fe992c088bfe");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Perfection", 
                Description = "You strive to perfect your mind, body, and spirit." 
            };
        }
    }
}
