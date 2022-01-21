using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class Lifelink : Template
    {
        public static readonly Guid ID = Guid.Parse("d20bfca9-9cb0-4268-b206-403fb40f053e");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Lifelink", 
                Description = " If your familiar would be reduced to 0 HP by damage, as a reaction with the concentrate trait, you can take the damage. If you do, you take all the damage and your familiar takes none. However, special effects that would occur due to that damage (such as snake venom) still apply to your familiar."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a5dc4b4-2c27-46b5-99ec-da7b8fb28858"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
