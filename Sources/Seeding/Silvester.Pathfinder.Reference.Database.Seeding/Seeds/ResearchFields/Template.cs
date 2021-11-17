using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ResearchFields
{
    public abstract class Template : EntityTemplate<ResearchField>
    {
        protected override ResearchField GetEntity(ISeedBuilder builder)
        {
            ResearchField field = GetResearchField();

            builder.AddEffect(field, GetEffects, e => e.EffectId);
            builder.AddSourcePage(field, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(field, GetDetails(), e => e.Details);

            return field;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract ResearchField GetResearchField();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
    }
}
