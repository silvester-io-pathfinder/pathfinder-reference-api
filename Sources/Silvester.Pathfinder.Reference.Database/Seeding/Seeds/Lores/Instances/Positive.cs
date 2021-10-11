using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Positive : Template
    {
        public static readonly Guid ID = Guid.Parse("3780881a-4913-43d5-be4f-26bb59737b90");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Positive"
            };
        }
    }
}
