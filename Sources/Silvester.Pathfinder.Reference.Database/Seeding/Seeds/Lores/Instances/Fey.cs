using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Fey : Template
    {
        public static readonly Guid ID = Guid.Parse("11929210-4d38-4bbb-b779-def38e69e5d2");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Fey"
            };
        }
    }
}
