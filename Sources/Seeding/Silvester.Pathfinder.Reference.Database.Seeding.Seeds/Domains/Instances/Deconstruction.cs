using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Deconstruction : Template
    {
        public static readonly Guid ID = Guid.Parse("d09b4a1e-21fd-4dda-9fe6-8679bd6e3eef");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Destruction", 
                Description = "You are a conduit for divine devastation." 
            };
        }
    }
}
