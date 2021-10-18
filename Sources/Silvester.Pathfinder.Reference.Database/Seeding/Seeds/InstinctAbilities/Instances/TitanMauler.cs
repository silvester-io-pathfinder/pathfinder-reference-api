using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities.Instances
{
    public class TitanMauler : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override InstinctAbility GetInstinctAbility()
        {
            return new InstinctAbility
            {
                Id = ID, 
                Name = "Titan Mauler",
                Description = "You can use a weapon built for a Large creature if you are Small or Medium (both normally and when raging). If you're not Small or Medium, you can use a weapon built for a creature one size larger than you. You gain access to this larger weapon, which can be of any weapon type otherwise available at character creation. It has the normal Price and Bulk for a weapon of its size. When wielding such a weapon in combat, increase your additional damage from Rage from 2 to 6, but you have the clumsy 1 condition because of the weapon's unwieldy size. You can't remove this clumsy condition or ignore its penalties by any means while wielding the weapon.",
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
