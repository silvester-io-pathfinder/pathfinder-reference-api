using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class SpellDelivery : Template
    {
        public static readonly Guid ID = Guid.Parse("76e3f7f1-bd11-4706-ab50-5337a74c7312");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Spell Delivery", 
                Description = "If your familiar is in your space, you can cast a spell with a range of touch, transfer its power to your familiar, and command the familiar to deliver the spell. If you do, the familiar uses its 2 actions for the round to move to a target of your choice and touch that target. If it doesn't reach the target to touch it this turn, the spell has no effect."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa17b3ec-2a33-469f-8ecc-2749010b1227"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
