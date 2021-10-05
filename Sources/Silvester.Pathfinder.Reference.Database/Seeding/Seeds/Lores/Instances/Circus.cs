using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Circus : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("3355e2fe-2868-4d57-8e78-0a6f6e7f9cd6");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Circus"
            };
        }
    }
}
