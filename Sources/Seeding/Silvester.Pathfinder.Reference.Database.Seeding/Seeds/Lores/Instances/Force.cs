using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Force : Template
    {
        public static readonly Guid ID = Guid.Parse("3b51c2d2-f5b8-4007-be91-6b1d80085635");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Force"
            };
        }
    }
}
