using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Labor : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("9986bcde-469b-42d1-abda-135f68daa6cf");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Labor"
            };
        }
    }
}
