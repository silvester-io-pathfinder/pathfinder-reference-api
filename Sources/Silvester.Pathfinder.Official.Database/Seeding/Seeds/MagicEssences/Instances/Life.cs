using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicEssences.Instances
{
    public class Life : Template
    {
        public static readonly Guid ID = Guid.Parse("044429ac-181c-46a8-b031-c163ae407509");

        protected override MagicEssence GetMagicEssence()
        {
            return new MagicEssence
            {
                Id = ID,
                Name = "Life",
                Description = "Also called heart, faith, instinct, or vital essence, life represents the animating universal force within all things. Whereas matter provides the base materials for a body, life keeps it alive and well. This essence is responsible for unconscious responses and belief, such as ancestral instincts and divine guidance. The divine and primal traditions hold power over life. Life spells are usually necromancy."
            };
        }
    }
}
