using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Architecture : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("972635f0-889d-411b-8f29-abf1ade9da18");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Architecture"
            };
        }
    }
}
