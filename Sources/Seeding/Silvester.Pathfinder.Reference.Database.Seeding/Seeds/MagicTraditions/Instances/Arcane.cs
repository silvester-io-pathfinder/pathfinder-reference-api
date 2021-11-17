using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicTraditions.Instances
{
    public class Arcane : Template
    {
        public static readonly Guid ID = Guid.Parse("10dddda5-a943-4ecb-ba33-57ceba60245e");

        protected override MagicTradition GetMagicTradition()
        {
            return new MagicTradition
            {
                Id = ID,
                Name = "Arcane",
                Description = "Arcane spellcasters use logic and rationality to categorize the magic inherent in the world around them. Because of its far-reaching approach, the arcane tradition has the broadest spell list, though it’s generally poor at affecting the spirit or the soul. Wizards are the most iconic arcane spellcasters, poring over tomes and grimoires, though arcane sorcerers study the secrets of their blood to unlock the power within themselves."
            };
        }
    }
}
