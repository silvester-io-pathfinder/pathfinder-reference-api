using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Ocean : Template
    {
        public static readonly Guid ID = Guid.Parse("88019235-3e51-4e8b-a17b-93210889f53e");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Ocean"
            };
        }
    }
}
