using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class FortuneTelling : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("1e08e096-27f7-4d62-a52a-642b87871d10");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Fortune Telling"
            };
        }
    }
}
