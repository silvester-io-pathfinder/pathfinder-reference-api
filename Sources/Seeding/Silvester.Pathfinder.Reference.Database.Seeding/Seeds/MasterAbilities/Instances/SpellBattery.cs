using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class SpellBattery : Template
    {
        public static readonly Guid ID = Guid.Parse("c49d080f-3f13-46ef-8b46-103bfbd12fd3");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Spell Battery", 
                Description = "You gain one additional spell slot at least 3 levels lower than your highest-level spell slot; you must be able to cast 4th-level spells using spell slots to select this master ability."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("610efe8b-5d2b-4c53-8a43-0be7be21eee5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
