using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances
{
    public class NeutralEvil : Template
    {
        public static readonly Guid ID = Guid.Parse("3a4f993d-9f0c-4615-b18a-39feb5b25a11");

        protected override Alignment GetAlignment()
        {
           return new Alignment 
           {
               Id = ID, 
               Name = "Neutral Evil", 
               Description = "A neutral evil character is typically selfish and has no qualms about turning on allies-of-the-moment, and usually makes allies primarily to further their own goals. A neutral evil character has no compunctions about harming others to get what they want, but neither will they go out of their way to cause carnage or mayhem when they see no direct benefit for themselves. Another valid interpretation of neutral evil holds up evil as an ideal, doing evil for evil's sake and trying to spread its influence. Examples of the first type are an assassin who has little regard for formal laws but does not needlessly kill, a henchman who plots behind their superior's back, or a mercenary who readily switches sides if made a better offer. An example of the second type would be a masked killer who strikes only for the sake of causing fear and distrust in the community." 
           };
        }
    }
}
