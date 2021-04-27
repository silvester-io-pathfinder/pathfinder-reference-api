using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Genealogy : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("a01a140e-95a0-483e-b472-a193751f8149");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Genealogy"
            };
        }
    }
}
