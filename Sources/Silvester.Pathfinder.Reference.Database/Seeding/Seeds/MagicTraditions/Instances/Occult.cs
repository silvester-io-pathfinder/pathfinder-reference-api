using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicTraditions.Instances
{
    public class Occult : Template
    {
        public static readonly Guid ID = Guid.Parse("8e4b2e84-303a-42eb-a4df-348d1c4fbbf8");

        protected override MagicTradition GetMagicTradition()
        {
            return new MagicTradition
            {
                Id = ID,
                Name = "Occult",
                Description = "The practitioners of occult traditions seek to understand the unexplainable, categorize the bizarre, and otherwise access the ephemeral in a systematic way. Bards are the most iconic occult spellcasters, collecting strange esoterica and using their performances to influence the mind or elevate the soul, and occult sorcerers strive to understand the mysterious power in their blood."
            };
        }
    }
}
