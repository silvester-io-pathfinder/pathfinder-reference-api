using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Electricity : Template
    {
        public static readonly Guid ID = Guid.Parse("34fe90a8-314c-451a-8dcc-e2a38c662260");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Electricity"
            };
        }
    }
}
