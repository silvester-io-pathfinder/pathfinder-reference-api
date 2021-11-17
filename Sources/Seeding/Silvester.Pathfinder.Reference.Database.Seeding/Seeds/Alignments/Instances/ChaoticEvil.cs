using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Alignments.Instances
{
    public class ChaoticEvil : Template
    {
        public static readonly Guid ID = Guid.Parse("25f9299a-9a7c-40bc-b8bd-58588d19381b");

        protected override Alignment GetAlignment()
        {
           return new Alignment 
           {
               Id = ID, 
               Name = "Chaotic Evil",
               Description = "A chaotic evil character tends to have no respect for rules, other people's lives, or anything but their own desires, which are typically selfish and cruel. They set a high value on personal freedom, but do not have much regard for the lives or freedom of other people. Chaotic evil characters do not work well in groups because they resent being given orders and usually do not behave themselves unless there is no alternative." 
           };
        }
    }
}
