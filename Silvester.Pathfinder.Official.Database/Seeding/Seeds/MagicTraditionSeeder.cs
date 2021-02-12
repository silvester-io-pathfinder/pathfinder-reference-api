using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class MagicTraditionSeeder : IEntitySeeder<MagicTradition>
    {
        public IEnumerable<MagicTradition> GetSeedEntities()
        {
            yield return new MagicTradition { Id = Guid.Parse("10dddda5-a943-4ecb-ba33-57ceba60245e"), Name = "Arcane", Description = "Arcane spellcasters use logic and rationality to categorize the magic inherent in the world around them. Because of its far-reaching approach, the arcane tradition has the broadest spell list, though it’s generally poor at affecting the spirit or the soul. Wizards are the most iconic arcane spellcasters, poring over tomes and grimoires, though arcane sorcerers study the secrets of their blood to unlock the power within themselves." };
            yield return new MagicTradition { Id = Guid.Parse("9dfb8bc7-ade4-4ce4-8aa5-1a17ab541698"), Name = "Divine", Description = "The power of the divine is steeped in faith, the unseen, and belief in a power source from beyond the Material Plane. Clerics are the most iconic divine spellcasters, beseeching the gods to grant them their magic. Divine sorcerers can use the blood of their celestial or fiendish ancestors as a divine conduit, and champions call upon their gods to grant them martial prowess through divine guidance." };
            yield return new MagicTradition { Id = Guid.Parse("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8"), Name = "Occult", Description = "The practitioners of occult traditions seek to understand the unexplainable, categorize the bizarre, and otherwise access the ephemeral in a systematic way. Bards are the most iconic occult spellcasters, collecting strange esoterica and using their performances to influence the mind or elevate the soul, and occult sorcerers strive to understand the mysterious power in their blood." };
            yield return new MagicTradition { Id = Guid.Parse("fffa34af-0ad5-4e1e-9de9-92becba8c30b"), Name = "Primal", Description = "An instinctual connection to and faith in the world, the cycle of day and night, the turning of the seasons, and the natural selection of predator and prey drive the primal tradition. Druids are the most iconic primal spellcasters, calling upon the magic of nature through deep faith and a connection to the plants and animals around them, and primal sorcerers call upon their fey or beast blood to harness the same natural energies." };
        }
    }
}
