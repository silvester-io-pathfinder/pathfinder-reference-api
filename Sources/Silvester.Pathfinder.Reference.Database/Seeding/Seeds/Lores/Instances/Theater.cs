using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Theater : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("9fd1286f-2ce0-4fe7-9152-565db6dc7b4a");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Theater"
            };
        }
    }
}
