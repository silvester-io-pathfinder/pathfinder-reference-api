using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class ImprovedFlexibility : Template
    {
        public static readonly Guid ID = Guid.Parse("5d3daf96-8edc-4572-aa51-19fd1364617f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Improved Flexibility", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("762d2490-ba36-4ae6-8ab1-957dfee46d12"), Type = TextBlockType.Text, Text = "Your extensive experience gives you even greater ability to adapt to each day's challenges. When you use combat flexibility, you can gain two fighter feats instead of one. While the first feat must still be 8th level or lower, the second feat can be up to 14th level, and you can use the first feat to meet the prerequisites of the second feat. You must meet all of the feat's prerequisites." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyDailyClassFeat(Guid.Parse("16c920c7-4c96-4549-86d4-b6350519d850"), Classes.Instances.Fighter.ID, level: 14);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c08fe586-abe4-4cf6-a9df-9890fa9e5298"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
