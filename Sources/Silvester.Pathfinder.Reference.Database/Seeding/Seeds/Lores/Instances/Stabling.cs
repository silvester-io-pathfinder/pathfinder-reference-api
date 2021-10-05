using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Stabling : Lores.Template
    {
        public static readonly Guid ID = Guid.Parse("15920edf-9202-476b-8ddb-5c0950c08adc");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Stabling"
            };
        }
    }
}
