using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Plague : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
