using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures
{
    public abstract class Template : EntityTemplate<ClassFeature>
    {
        protected override ClassFeature GetEntity(ModelBuilder builder)
        {
            ClassFeature classFeature = GetClassFeature();

            builder.AddEffects(GetEffects(), (e) => new ClassFeatureEffectBinding { ClauseFeatureId = classFeature.Id });
            builder.AddSourcePage(classFeature, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(classFeature, GetDetails(), e => e.Details);

            return classFeature;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract ClassFeature GetClassFeature();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Effect> GetEffects();
    }
}
