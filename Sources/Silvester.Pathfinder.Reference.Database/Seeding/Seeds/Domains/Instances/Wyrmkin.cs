using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Wyrmkin : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Wyrmkin", 
                Description = "You draw on the power of dragons, linnorms, and other powerful reptilian creatures."
            };
        }
    }
}
