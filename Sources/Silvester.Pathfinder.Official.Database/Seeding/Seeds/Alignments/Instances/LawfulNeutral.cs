using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances
{
    public class LawfulNeutral : Template
    {
        public static readonly Guid ID = Guid.Parse("617c34ca-c11b-4c02-9f97-5ce7269f98bc");

        protected override Alignment GetAlignment()
        {
           return new Alignment 
           {
               Id = ID, 
               Name = "Lawful Neutral", 
               Description = "A lawful neutral character typically believes strongly in lawful concepts such as honor, order, rules, and tradition, but often follows a personal code in addition to, or even in preference to, one set down by a benevolent authority. Examples of this alignment include a soldier who always follows orders, a judge or enforcer who adheres mercilessly to the letter of the law, or a disciplined monk." 
           };
        }
    }
}
