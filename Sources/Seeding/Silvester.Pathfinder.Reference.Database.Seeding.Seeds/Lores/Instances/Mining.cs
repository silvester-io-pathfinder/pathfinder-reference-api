using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Mining : Template
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
