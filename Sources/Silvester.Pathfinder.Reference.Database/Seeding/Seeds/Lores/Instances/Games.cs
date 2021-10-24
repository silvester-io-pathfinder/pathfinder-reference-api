using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Games : Template
    {
        public static readonly Guid ID = Guid.Parse("59c448b6-53f8-46d4-a547-d8a7ff86d334");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Games"
            };
        }
    }
}
