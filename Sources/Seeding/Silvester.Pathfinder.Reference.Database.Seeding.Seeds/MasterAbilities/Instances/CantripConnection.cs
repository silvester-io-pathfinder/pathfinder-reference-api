using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class CantripConnection : Template
    {
        public static readonly Guid ID = Guid.Parse("d8766fda-ec3a-4bb3-b38f-72abde5a31b0");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Cantrip Connection", 
                Description = "You can prepare an additional cantrip, or if you have a repertoire, instead designate a cantrip to add to your repertoire every time you select this ability; you can retrain it but can�t otherwise change it. You must be able to prepare cantrips or add them to your repertoire to select this."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14895d2f-9a1d-4b18-a3d0-dac2ffc33def"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
