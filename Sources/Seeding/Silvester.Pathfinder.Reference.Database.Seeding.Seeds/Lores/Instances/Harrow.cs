using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Harrow : Template
    {
        public static readonly Guid ID = Guid.Parse("413cd880-3286-45ae-a311-d6bb5d46b630");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Harrow"
            };
        }
    }
}
