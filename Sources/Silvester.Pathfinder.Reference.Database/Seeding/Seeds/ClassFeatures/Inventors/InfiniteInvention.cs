using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class InfiniteInvention : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Infinite Invention", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ability to adjust your innovation has reached impossible heights, and you can use these skills to make major adjustments in your spare time. During your daily preparations, you automatically fix your innovation if it's destroyed or broken, and you can change to a different innovation (armor, construct, weapon, or other type you have access to) and change your modifications and offensive boost." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you have any feats that had your previous innovation as a prerequisite, you can't use them until you retrain the feats as normal. However, it takes you only 1 day of downtime to retrain such a feat into a feat that has your new innovation as a prerequisite, instead of 1 week." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //TODO: Add effects.
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 24
            };
        }
    }
}
