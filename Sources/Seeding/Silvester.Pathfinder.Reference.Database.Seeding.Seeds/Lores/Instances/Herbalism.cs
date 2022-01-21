using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Herbalism : Template
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
