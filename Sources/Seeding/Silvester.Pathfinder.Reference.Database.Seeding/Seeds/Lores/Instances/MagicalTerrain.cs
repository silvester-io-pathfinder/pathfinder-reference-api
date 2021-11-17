using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class MagicalTerrain : Template
    {
        public static readonly Guid ID = Guid.Parse("bd8a014a-0f08-4043-b02d-42fd0998a6eb");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Magical Terrain"
            };
        }
    }
}
