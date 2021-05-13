using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances
{
    public class ChaoticGood : Template
    {
        public static readonly Guid ID = Guid.Parse("add12009-9c8a-4287-b02b-7e5b9459bf44");

        protected override Alignment GetAlignment()
        {
            return new Alignment 
            { 
               Id = ID, 
               Name = "Chaotic Good", 
               Description = "A chaotic good character does what is necessary to bring about change for the better, disdains bureaucratic organizations that get in the way of social improvement, and places a high value on personal freedom, not only for oneself, but for others as well. Chaotic good characters usually intend to do the right thing, but their methods are generally disorganized and often out of sync with the rest of society." 
            };
        }
    }
}
