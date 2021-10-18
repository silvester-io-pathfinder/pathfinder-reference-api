using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ResearchFields
{
    public abstract class Template : EntityTemplate<ResearchField>
    {
        protected override ResearchField GetEntity(ModelBuilder builder)
        {
            ResearchField field = GetResearchField();

            builder.AddEffects(GetEffects(), (e) => new ResearchFieldEffectBinding { ResearchFieldId = field.Id });
            builder.AddSourcePage(field, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(field, GetDetails(), e => e.Details);

            return field;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract ResearchField GetResearchField();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Effect> GetEffects();
    }
}
