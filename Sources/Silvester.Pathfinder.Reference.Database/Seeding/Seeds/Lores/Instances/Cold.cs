using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Acid : Template
    {
        public static readonly Guid ID = Guid.Parse("755e1b86-d5d8-41b0-b180-7ace60edb374");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Acid"
            };
        }
    }
}
