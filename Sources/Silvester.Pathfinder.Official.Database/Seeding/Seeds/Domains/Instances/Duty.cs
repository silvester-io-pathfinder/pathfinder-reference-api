using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Duty : Template
    {
        public static readonly Guid ID = Guid.Parse("ef17f4d2-95cd-4561-86fc-487a749244e4");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Duty", 
                Description = "You defend oaths and carry out your divine missions with great dedication." 
            };
        }
    }
}
