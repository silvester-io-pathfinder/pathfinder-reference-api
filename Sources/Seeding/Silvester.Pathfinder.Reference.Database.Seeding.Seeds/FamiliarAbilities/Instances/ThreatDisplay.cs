using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class ThreatDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("f7059a0e-d063-441b-939d-b903118df99f");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Threat Display", 
                Description = "Your familiar helps you convey wordless threats through body language. Whenever you attempt an Intimidation check to Demoralize a creature, if your familiar is within 30 feet of your target and can act, it accompanies you with snarls, hisses, or raising its hackles. If it can do so, you don't take the normal -4 penalty on the Intimidation check if your target doesn't understand the language you're speaking."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e6c2440-f0a6-419b-89ef-063df9165a7b"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
