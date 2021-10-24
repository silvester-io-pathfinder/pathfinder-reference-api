using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Glyph : Template
    {
        public static readonly Guid ID = Guid.Parse("bc369149-d7c5-4319-b7d8-8137f9cfdcd8");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Glyph", 
                Description = "You wield power over written words and symbols." 
            };
        }
    }
}
