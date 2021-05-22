using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Creation : Template
    {
        public static readonly Guid ID = Guid.Parse("0b2dd6ec-60ae-4cab-ade5-b5bccdc8a993");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Creation", 
                Description = "You have divine abilities related to crafting and art." 
            };
        }
    }
}
