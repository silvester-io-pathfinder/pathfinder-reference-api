using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Genealogy : Template
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
