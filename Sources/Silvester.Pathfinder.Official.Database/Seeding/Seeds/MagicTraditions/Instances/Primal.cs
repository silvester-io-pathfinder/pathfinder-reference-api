using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicTraditions.Instances
{
    public class Primal : Template
    {
        public static readonly Guid ID = Guid.Parse("fffa34af-0ad5-4e1e-9de9-92becba8c30b");

        protected override MagicTradition GetMagicTradition()
        {
            return new MagicTradition
            {
                Id = ID,
                Name = "Primal",
                Description = "An instinctual connection to and faith in the world, the cycle of day and night, the turning of the seasons, and the natural selection of predator and prey drive the primal tradition. Druids are the most iconic primal spellcasters, calling upon the magic of nature through deep faith and a connection to the plants and animals around them, and primal sorcerers call upon their fey or beast blood to harness the same natural energies."
            };
        }
    }
}
