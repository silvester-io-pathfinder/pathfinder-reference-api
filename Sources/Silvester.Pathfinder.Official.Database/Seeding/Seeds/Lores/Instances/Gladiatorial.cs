using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Gladiatorial : Lores.Template
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
