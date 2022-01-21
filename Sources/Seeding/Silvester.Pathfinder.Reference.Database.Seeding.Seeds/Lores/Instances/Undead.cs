using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Undead : Template
    {
        public static readonly Guid ID = Guid.Parse("615fca8d-0b1b-43be-8f28-0fbe0251eb64");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Undead"
            };
        }
    }
}
