using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class InfiniteInvention : Template
    {
        public static readonly Guid ID = Guid.Parse("b605e057-e8c3-4c3a-966f-12cff7a68cc8");

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
            yield return new TextBlock { Id = Guid.Parse("08579eb9-2ba3-410a-9aa9-2f1f6aa2a117"), Type = TextBlockType.Text, Text = "Your ability to adjust your innovation has reached impossible heights, and you can use these skills to make major adjustments in your spare time. During your daily preparations, you automatically fix your innovation if it's destroyed or broken, and you can change to a different innovation (armor, construct, weapon, or other type you have access to) and change your modifications and offensive boost." };
            yield return new TextBlock { Id = Guid.Parse("e5959802-2735-450d-8466-39511cc2bef9"), Type = TextBlockType.Text, Text = "If you have any feats that had your previous innovation as a prerequisite, you can't use them until you retrain the feats as normal. However, it takes you only 1 day of downtime to retrain such a feat into a feat that has your new innovation as a prerequisite, instead of 1 week." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac87cb4b-ad77-4b92-ad53-e6b3b328a1d9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 24
            };
        }
    }
}
