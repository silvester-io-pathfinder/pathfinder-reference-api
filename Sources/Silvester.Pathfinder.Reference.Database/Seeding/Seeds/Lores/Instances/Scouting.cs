using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Scouting : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("f1b92dd2-deef-4baa-b744-506ddb77f169");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Scouting"
            };
        }
    }
}
