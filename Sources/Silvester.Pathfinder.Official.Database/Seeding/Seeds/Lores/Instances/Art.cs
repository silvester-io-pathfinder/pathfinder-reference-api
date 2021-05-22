using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Art : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("c523fba8-bdfc-4eae-bd83-3735c421fc6c");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Art"
            };
        }
    }
}
