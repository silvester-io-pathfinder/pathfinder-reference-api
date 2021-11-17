using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Lores.Instances
{
    public class Elven : Template
    {
        public static readonly Guid ID = Guid.Parse("b6d17c4d-7daa-4da3-b316-a71138991596");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Elven"
            };
        }
    }
}
