using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Guild : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("67ef16b1-79f0-4078-870f-ea8f8c6f95c7");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Guild"
            };
        }
    }
}
