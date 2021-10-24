using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AncestrySizes.Instances
{
    public class Huge : Template
    {
        public static readonly Guid ID = Guid.Parse("eba80c08-8f5b-4dee-8d43-f1aa5fc30d8b");
        
        protected override AncestrySize GetAncestrySize()
        {
            return new AncestrySize
            {
                Id = ID,
                Name = "Huge",
                Space = 15, 
                BreadthReach = 15,
                HeightReach = 20
            };
        }
    }
}
