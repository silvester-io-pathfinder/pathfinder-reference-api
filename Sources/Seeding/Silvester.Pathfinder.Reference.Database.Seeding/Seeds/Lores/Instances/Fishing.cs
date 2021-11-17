using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Fishing : Template
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
