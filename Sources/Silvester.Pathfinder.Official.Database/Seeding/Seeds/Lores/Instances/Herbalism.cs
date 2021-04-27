using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Herbalism : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("895ec4d4-9130-439b-84ca-1179973008fc");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Herbalism"
            };
        }
    }
}
