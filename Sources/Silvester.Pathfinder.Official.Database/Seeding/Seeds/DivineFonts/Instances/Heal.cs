using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DivineFonts.Instances
{
    public class Heal : AbstractDivineFontTemplate
    {
        public static readonly Guid ID = Guid.Parse("90698ae0-eb7f-49f2-b485-d7a1f9baf653");

        protected override DivineFont GetDivineFont()
        {
            return new DivineFont 
            { 
                Id = ID, 
                Name = "Heal", 
                Description = "You gain additional spell slots each day at your highest level of cleric spell slots. You can prepare only heal spells (page 343) in these slots, and the number of slots is equal to 1 plus your Charisma modifier." 
            };

        }
    }
}
