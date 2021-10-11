using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Genie : Template
    {
        public static readonly Guid ID = Guid.Parse("3bb6a0fb-1f74-4211-87b4-d49c527c15d4");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Genie"
            };
        }
    }
}
