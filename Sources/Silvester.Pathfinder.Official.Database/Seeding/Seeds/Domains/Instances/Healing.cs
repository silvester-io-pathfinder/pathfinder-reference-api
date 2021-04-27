using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Healing : AbstractDomainTemplate
    {
        public static readonly Guid ID = Guid.Parse("3b1c75b0-524c-4a08-b04b-9e66b69b42fc");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Healing", 
                Description = "Your healing magic is particularly potent." 
            };
        }
    }
}
