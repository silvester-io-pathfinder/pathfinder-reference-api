using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Library : Template
    {
        public static readonly Guid ID = Guid.Parse("f3e8b6c2-238f-4354-aa4f-f638398e851e");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Library"
            };
        }
    }
}
