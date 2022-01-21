using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class QuickRage : Template
    {
        public static readonly Guid ID = Guid.Parse("03a4d7cf-367e-4c5d-9da3-5b44f7f1e2b3");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Quick Rage", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fd0c1589-6102-4458-bd59-810623fed1ad"), Type = TextBlockType.Text, Text = "You recover from your Rage quickly, and are soon ready to begin anew. After you spend a full turn without raging, you can Rage again without needing to wait 1 minute." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add modify rage effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("470f9179-a940-4230-821b-0cfad29874e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
