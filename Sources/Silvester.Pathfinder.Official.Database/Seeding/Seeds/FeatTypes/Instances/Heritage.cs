using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FeatTypes.Instances
{
    public class Heritage : Template
    {
        public static readonly Guid ID = Guid.Parse("c15fb53a-0b27-47c1-8ef4-eba2d982075c");

        protected override FeatType GetAction()
        {
            return new FeatType
            {
                Id = ID,
                Name = "Heritage"
            };
        }
    }
}
