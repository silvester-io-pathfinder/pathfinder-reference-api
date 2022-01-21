using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class RecallFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("3decdb4c-041b-415d-a6ee-4cead456e8b6");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Recall Familiar", 
                Description = "You can summon your familiar to your side. Once per day, you can use a 3-action activity, which has the concentrate trait, to teleport your familiar to your space. Your familiar must be within 1 mile or the attempt to summon it fails. This is a conjuration and teleport effect."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2682cf8-7d70-409b-955a-4c8f1ab54100"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
