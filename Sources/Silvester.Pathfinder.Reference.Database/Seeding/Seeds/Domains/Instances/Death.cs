using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Death : Template
    {
        public static readonly Guid ID = Guid.Parse("21481675-8a0d-4e7c-a373-fad64f4c14e7");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Death", 
                Description = "You have the power to end lives and destroy undead." 
            };
        }
    }
}
