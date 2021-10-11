using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Kobold : Template
    {
        public static readonly Guid ID = Guid.Parse("35a013c4-cbdb-4a6a-9794-a9a7145c0994");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Kobold"
            };
        }
    }
}
