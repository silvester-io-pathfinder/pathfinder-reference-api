using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Naga : Template
    {
        public static readonly Guid ID = Guid.Parse("d9d57061-a45f-4c83-8156-7edb40004558");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Naga", 
                Description = "Like the serpentine nagas, you're in tune with cosmic forces that Ravithra once controlled."
            };
        }
    }
}
