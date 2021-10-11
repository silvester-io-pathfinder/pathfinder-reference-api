using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Cold : Template
    {
        public static readonly Guid ID = Guid.Parse("8e80070f-8c9e-4733-a09d-6fe49e5768a3");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Cold"
            };
        }
    }
}
