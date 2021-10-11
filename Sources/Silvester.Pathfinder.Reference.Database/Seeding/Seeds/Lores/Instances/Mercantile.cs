using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Mercantile : Template
    {
        public static readonly Guid ID = Guid.Parse("a017fa74-7dd3-4e49-b0ab-e56b53acb642");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Mercantile"
            };
        }
    }
}
