using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SenseAccuracies.Instances
{
    public class Imprecise : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override SenseAccuracy GetSenseAccuracy()
        {
            return new SenseAccuracy
            {
                Id = ID, 
                Name = "Imprecise",
                Description = "Hearing is an imprecise sense—it cannot detect the full range of detail that a precise sense can. You can usually sense a creature automatically with an imprecise sense, but it has the hidden condition instead of the observed condition. It might be undetected by you if it’s using Stealth or is in an environment that distorts the sense, such as a noisy room in the case of hearing. In those cases, you have to use the Seek basic action to detect the creature. At best, an imprecise sense can be used to make an undetected creature (or one you didn’t even know was there) merely hidden—it can’t make the creature observed."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 464
            };
        }
    }
}
