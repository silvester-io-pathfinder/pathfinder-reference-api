using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses
{
    public abstract class Template : EntityTemplate<ArcaneThesis>
    {
        protected override ArcaneThesis GetEntity(ModelBuilder builder)
        {
            ArcaneThesis thesis = GetArcaneThesis();

            builder.AddEffect(thesis, GetEffects, (thesis) => thesis.EffectId);
            builder.AddSourcePage(thesis, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(thesis, GetDetails(), e => e.Details);

            return thesis;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract ArcaneThesis GetArcaneThesis();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract void GetEffects(BooleanEffectBuilder binder);
    }
}
