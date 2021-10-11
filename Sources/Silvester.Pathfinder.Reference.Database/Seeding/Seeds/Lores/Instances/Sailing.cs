using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Sailing : Template
    {
        public static readonly Guid ID = Guid.Parse("efa5a63f-a6df-4e20-8834-eef62de65127");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Sailing"
            };
        }
    }
}
