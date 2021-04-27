using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DivineFonts.Instances
{
    public class Harm : AbstractDivineFontTemplate
    {
        public static readonly Guid ID = Guid.Parse("f724073c-4395-4f57-91ff-21fca4f0a6be");

        protected override DivineFont GetDivineFont()
        {
            return new DivineFont 
            { 
                Id = ID, 
                Name = "Harm", 
                Description = "You gain additional spell slots each day at your highest level of cleric spell slots. You can prepare only harm spells (page 343) in these slots, and the number of slots is equal to 1 plus your Charisma modifier." 
            };
        }
    }
}
