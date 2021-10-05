using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Alignments.Instances
{
    public class NeutralGood : Template
    {
        public static readonly Guid ID = Guid.Parse("e45c48a5-db00-4056-8ef3-7bd3662cfd9f");

        protected override Alignment GetAlignment()
        {
           return new Alignment 
           { 
               Id = ID, 
               Name = "Neutral Good",
               Description = "A neutral good character typically acts altruistically, without regard for or against lawful precepts such as rules or tradition. A neutral good character has no problems with cooperating with lawful officials, but does not feel beholden to them. In the event that doing the right thing requires the bending or breaking of rules, they do not suffer the same inner conflict that a lawful good character would." 
           };
        }
    }
}
