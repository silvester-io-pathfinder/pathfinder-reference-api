using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Engineering : Template
    {
        public static readonly Guid ID = Guid.Parse("f86f9546-665e-4a31-8f98-8162ea95add1");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Engineering"
            };
        }
    }
}
