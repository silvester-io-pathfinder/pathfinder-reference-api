using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Cooking : Template
    {
        public static readonly Guid ID = Guid.Parse("dfe38392-5d14-4b7d-83e7-ebc6c351dda3");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "MinCookinging"
            };
        }
    }
}
