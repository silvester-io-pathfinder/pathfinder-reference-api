using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Negative : Template
    {
        public static readonly Guid ID = Guid.Parse("bc91ba12-9552-4c88-b146-f41d7817aacc");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Negative"
            };
        }
    }
}
