using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Art : Template
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
