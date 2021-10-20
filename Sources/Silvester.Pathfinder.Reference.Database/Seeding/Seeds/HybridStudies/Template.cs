using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HybridStudies
{
    public abstract class Template : EntityTemplate<HybridStudy>
    {
        protected override HybridStudy GetEntity(ModelBuilder builder)
        {
            HybridStudy study = GetHybridStudy();

            builder.AddTextBlocks(study, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(study, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffects(GetEffects(), (effect) => new HybridStudyEffectBinding { HybridStudyId = study.Id });

            return study;
        }

        protected abstract HybridStudy GetHybridStudy();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Effect> GetEffects();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
