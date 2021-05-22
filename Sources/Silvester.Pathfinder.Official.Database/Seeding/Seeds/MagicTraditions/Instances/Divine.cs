using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicTraditions.Instances
{
    public class Divine : Template
    {
        public static readonly Guid ID = Guid.Parse("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698");

        protected override MagicTradition GetMagicTradition()
        {
            return new MagicTradition
            {
                Id = ID,
                Name = "Divine",
                Description = "The power of the divine is steeped in faith, the unseen, and belief in a power source from beyond the Material Plane. Clerics are the most iconic divine spellcasters, beseeching the gods to grant them their magic. Divine sorcerers can use the blood of their celestial or fiendish ancestors as a divine conduit, and champions call upon their gods to grant them martial prowess through divine guidance."
            };
        }
    }
}
