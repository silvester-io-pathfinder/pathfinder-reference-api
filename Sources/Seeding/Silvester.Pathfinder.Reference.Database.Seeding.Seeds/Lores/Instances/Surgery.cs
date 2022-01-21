using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Surgery : Template
    {
        public static readonly Guid ID = Guid.Parse("7ddac40b-83b6-4d5c-b82d-53850a271a87");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Surgery"
            };
        }
    }
}
