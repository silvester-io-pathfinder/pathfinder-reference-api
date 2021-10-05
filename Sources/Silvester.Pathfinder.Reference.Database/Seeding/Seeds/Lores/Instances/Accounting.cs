using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Accounting : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("76dc8338-d86c-40a7-8a9c-15d64006bfb4");
       
        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Accounting"
            };
        }
    }
}
