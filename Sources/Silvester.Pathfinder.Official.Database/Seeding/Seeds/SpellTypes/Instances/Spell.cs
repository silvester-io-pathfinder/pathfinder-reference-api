using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellTypes.Instances
{
    public class Spell : Template
    {
        public static readonly Guid ID = Guid.Parse("daeadc1d-bf76-442b-9b4c-8276fa9effac");

        public override SpellType GetSpellType()
        {
           return new SpellType 
           { 
               Id = ID, 
               Name = "Spell", 
               Description = "A regular spell that has to be prepared or can be cast spontaneously, without any additional focus requirements, using a spell slot in the process." 
           };
        }
    }
}
