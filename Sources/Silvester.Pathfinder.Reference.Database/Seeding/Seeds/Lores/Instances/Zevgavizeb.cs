using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Zevgavizeb : Template
    {
        public static readonly Guid ID = Guid.Parse("6861e730-5119-4859-87b0-bc0637aba9dc");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Zevgavizeb"
            };
        }
    }
}
