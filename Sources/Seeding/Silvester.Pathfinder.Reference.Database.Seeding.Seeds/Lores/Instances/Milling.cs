using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Milling : Template
    {
        public static readonly Guid ID = Guid.Parse("72e8509a-c5b4-46be-9988-607f9786626b");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Milling"
            };
        }
    }
}
