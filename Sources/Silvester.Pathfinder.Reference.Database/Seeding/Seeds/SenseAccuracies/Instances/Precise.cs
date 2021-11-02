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
    public class Precise : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override SenseAccuracy GetSenseAccuracy()
        {
            return new SenseAccuracy
            {
                Id = ID, 
                Name = "Precise",
                Description = "Average vision is a precise sense—a sense that can be used to perceive the world in nuanced detail. The only way to target a creature without having drawbacks is to use a precise sense. You can usually detect a creature automatically with a precise sense unless that creature is hiding or obscured by the environment, in which case you can use the Seek basic action to better detect the creature."
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
