using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Alignments.Instances
{
    public class LawfulEvil : Template
    {
        public static readonly Guid ID = Guid.Parse("54f32060-3da3-4edf-b6dc-3839b8b7415d");

        protected override Alignment GetAlignment()
        {
           return new Alignment 
           {
               Id = ID, 
               Name = "Lawful Evil",
               Description = "A lawful evil character sees a well-ordered system as being easier to exploit than to necessarily follow. Examples of this alignment include tyrants, dictators, corrupt officials, or undiscriminating mercenary types who have a strict code of conduct." 
           };
        }
    }
}
