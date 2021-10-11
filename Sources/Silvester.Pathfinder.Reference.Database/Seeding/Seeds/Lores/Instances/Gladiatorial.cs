using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Gladiatorial : Template
    {
        public static readonly Guid ID = Guid.Parse("0d91d63d-082b-472e-bc07-a68d17c20f80");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Gladiatorial"
            };
        }
    }
}
