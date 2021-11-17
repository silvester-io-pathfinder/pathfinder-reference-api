using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Wyrmkin : Template
    {
        public static readonly Guid ID = Guid.Parse("001e108d-9b3f-46b8-88a7-a6ae05bade49");

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
