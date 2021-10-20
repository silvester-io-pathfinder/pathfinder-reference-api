using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class GunslingersWay : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Gunslinger's Way", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "All gunslingers have a particular way they follow, a combination of philosophy and combat style that defines both how they fight and the weapons they excel with. At 1st level, your way grants you an initial deed, a unique reload action called a slinger's reload, and proficiency with a particular skill. You also gain advanced and greater deeds at later levels, as well as access to way-specific feats." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyGunslingersWayEffect { Id = Guid.Parse("") };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 106
            };
        }
    }
}
