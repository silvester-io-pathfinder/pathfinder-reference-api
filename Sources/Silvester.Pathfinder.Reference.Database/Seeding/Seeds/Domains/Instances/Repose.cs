using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Repose : Template
    {
        public static readonly Guid ID = Guid.Parse("4387ee8e-ad61-4d20-817a-deeebc8bb1da");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Repose", 
                Description = "You ease mental burdens" 
            };
        }
    }
}
