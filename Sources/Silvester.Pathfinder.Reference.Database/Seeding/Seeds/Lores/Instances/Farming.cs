using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Farming : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("ecd24e93-d6b6-46a4-8866-b4292df19c11");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Farming"
            };
        }
    }
}
