using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Fire : Template
    {
        public static readonly Guid ID = Guid.Parse("395d967b-8889-4d67-acc2-210ae4b34275");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Fire"
            };
        }
    }
}
