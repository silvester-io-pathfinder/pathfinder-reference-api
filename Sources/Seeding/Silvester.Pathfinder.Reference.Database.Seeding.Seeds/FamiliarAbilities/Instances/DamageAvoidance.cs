using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class DamageAvoidance : Template
    {
        public static readonly Guid ID = Guid.Parse("f5aaae32-0ed3-4f12-ad1f-a190e3839da7");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Damage Avoidance", 
                Description = "Choose one type of save. It takes no damage when it rolls a success on that type of save; this doesn't prevent effects other than damage."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb861270-84c1-474d-9df6-a22fd305769a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
