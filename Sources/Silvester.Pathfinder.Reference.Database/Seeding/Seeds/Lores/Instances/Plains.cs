using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Plains : Template
    {
        public static readonly Guid ID = Guid.Parse("efa753e4-d9bc-4c13-aaf5-5f6ce61a29de");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Plains"
            };
        }
    }
}
