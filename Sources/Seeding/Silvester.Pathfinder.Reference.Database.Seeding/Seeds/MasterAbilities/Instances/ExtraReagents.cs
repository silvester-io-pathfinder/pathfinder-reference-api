using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class ExtraReagents : Template
    {
        public static readonly Guid ID = Guid.Parse("37224427-ac5e-4184-9855-b83033750a03");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Extra Reagents", 
                Description = "Your familiar grows extra infused reagents on or in its body. You gain an additional batch of infused reagents. You must have the infused reagents ability to select this ability."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87514abf-a203-4daa-b4f6-9c8e7a3df581"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
