using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Undeath : Template
    {
        public static readonly Guid ID = Guid.Parse("8e2fe9d1-c723-4754-8cb3-8955bb0094fc");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Undeath", 
                Description = "Your magic carries close ties to the undead." 
            };
        }
    }
}
