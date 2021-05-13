using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Fishing : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("3cb1887c-28e5-4927-b40e-2b9b579126b2");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Fishing"
            };
        }
    }
}
