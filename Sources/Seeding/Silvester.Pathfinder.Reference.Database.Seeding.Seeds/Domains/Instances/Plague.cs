using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Plague : Template
    {
        public static readonly Guid ID = Guid.Parse("d3ff94b7-76ba-4190-a8eb-f633e620bd99");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Plague", 
                Description = "You wield disease and pestilence like a weapon."
            };
        }
    }
}
