using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Midwifery : Template
    {
        public static readonly Guid ID = Guid.Parse("194009eb-8f7e-4f2d-b273-116080106e16");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Midwifery"
            };
        }
    }
}
