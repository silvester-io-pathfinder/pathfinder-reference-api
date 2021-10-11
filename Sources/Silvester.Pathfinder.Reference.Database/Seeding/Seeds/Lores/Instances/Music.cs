using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Music : Template
    {
        public static readonly Guid ID = Guid.Parse("464ea56b-80b1-4ff7-ba49-53b26af884ca");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Music"
            };
        }
    }
}
