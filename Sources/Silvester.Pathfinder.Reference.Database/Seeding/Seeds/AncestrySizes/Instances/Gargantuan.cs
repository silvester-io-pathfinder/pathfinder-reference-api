using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AncestrySizes.Instances
{
    public class Gargantuan : Template
    {
        public static readonly Guid ID = Guid.Parse("93daa531-f40c-4db8-8cc2-65f8e32b951b");

        protected override AncestrySize GetAncestrySize()
        {
            return new AncestrySize
            {
                Id = ID,
                Name = "Gargantuan",
                Space = 20, 
                BreadthReach = 20,
                HeightReach = 15
            };
        }
    }
}
