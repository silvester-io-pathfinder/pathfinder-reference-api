using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Driving : Template
    {
        public static readonly Guid ID = Guid.Parse("20ff12fb-6799-4bc7-a5f4-3e10a2c969dd");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Driving"
            };
        }
    }
}
