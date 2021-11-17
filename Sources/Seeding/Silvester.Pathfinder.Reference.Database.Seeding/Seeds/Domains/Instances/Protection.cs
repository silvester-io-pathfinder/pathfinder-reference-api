using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Protection : Template
    {
        public static readonly Guid ID = Guid.Parse("9eafb500-89d8-46ff-b315-856f11aca152");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Protection", 
                Description = "You ward yourself and others." 
            };
        }
    }
}
