using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HybridStudies
{
    public abstract class Template : EntityTemplate<HybridStudy>
    {
        protected override HybridStudy GetEntity(ISeedBuilder builder)
        {
            HybridStudy study = GetHybridStudy();

            builder.AddTextBlocks(study, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(study, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(study, GetEffects, e => e.EffectId);

            return study;
        }

        protected abstract HybridStudy GetHybridStudy();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
