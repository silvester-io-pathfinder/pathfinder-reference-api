using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Heraldry : Template
    {
        public static readonly Guid ID = Guid.Parse("2c700b95-816a-49a5-ac14-4d00798f1c66");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Heraldry"
            };
        }
    }
}
