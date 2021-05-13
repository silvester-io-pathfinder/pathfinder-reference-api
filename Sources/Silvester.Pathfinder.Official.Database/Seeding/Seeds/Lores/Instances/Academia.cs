using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Academia : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("a20da31f-7ed2-41a3-99e2-2105144ae00c");
        
        protected override Lore GetLore()
        {
            return new Lore 
            { 
                Id = ID, 
                StatModifierId = Stats.Instances.Intelligence.ID, 
                Name = "Academia" 
            };
        }
    }
}
