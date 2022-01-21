using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Healing : Template
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
