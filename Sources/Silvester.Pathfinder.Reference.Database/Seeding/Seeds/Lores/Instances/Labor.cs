using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Labor : Template
    {
        public static readonly Guid ID = Guid.Parse("9986bcde-469b-42d1-abda-135f68daa6cf");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Labor"
            };
        }
    }
}
