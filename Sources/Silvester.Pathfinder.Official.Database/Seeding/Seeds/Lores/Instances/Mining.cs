using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Mining : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("0a92a9ed-a7b5-4b76-a011-d0c061786294");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Mining"
            };
        }
    }
}
