using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Hunting : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("4123ef14-b7b4-4260-ae75-67e62a136d92");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Hunting"
            };
        }
    }
}
