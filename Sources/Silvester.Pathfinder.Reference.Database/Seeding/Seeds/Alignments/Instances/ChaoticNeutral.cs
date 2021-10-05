using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Alignments.Instances
{
    public class ChaoticNeutral : Template
    {
        public static readonly Guid ID = Guid.Parse("2ad80bbd-a735-4431-9e3a-f784e053b756");

        protected override Alignment GetAlignment()
        {
           return new Alignment 
           {
               Id = ID, 
               Name = "Chaotic Neutral",
               Description = "A chaotic neutral character is an individualist who follows their own heart and generally shirks rules and traditions. Although chaotic neutral characters promote the ideals of freedom, it is their own freedom that comes first; good and evil come second to their need to be free." 
           };
        }
    }
}
