using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Warfare : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("2b728d17-8d3c-42fc-aa53-08e5d73debd9");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Warfare"
            };
        }
    }
}
