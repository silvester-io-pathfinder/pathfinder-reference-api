using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FeatTypes.Instances
{
    public class General : Template
    {
        public static readonly Guid ID = Guid.Parse("58ef6c11-b8bd-411e-8222-6434fa491d11");

        protected override FeatType GetAction()
        {
            return new FeatType
            {
                Id = ID,
                Name = "General"
            };
         
        }
    }
}
