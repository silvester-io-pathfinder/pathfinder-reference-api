using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures
{
    public abstract class Template : EntityTemplate<ClassFeature>
    {
        protected override ClassFeature GetEntity(ISeedBuilder builder)
        {
            ClassFeature classFeature = GetClassFeature();

            builder.AddEffect(classFeature, builder => GetEffectsInternal(builder, classFeature), e => e.EffectId); 
            builder.AddSourcePage(classFeature, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(classFeature, GetDetails(), e => e.Details);

            return classFeature;
        }

        private void GetEffectsInternal(BooleanEffectBuilder builder, ClassFeature classFeature)
        {
            //Always adds the class feature's level as a prerequisite to the entire effect.
            builder
                .AddPrerequisites(classFeature.Id.Increment(1), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(classFeature.Id.Increment(2), Comparator.GreaterThanOrEqualTo, classFeature.Level);
                });

            GetEffects(builder);
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract ClassFeature GetClassFeature();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
    }
}
