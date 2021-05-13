using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Template : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("17263b3d-7c4f-439b-9f67-0f4e577a26af");

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
