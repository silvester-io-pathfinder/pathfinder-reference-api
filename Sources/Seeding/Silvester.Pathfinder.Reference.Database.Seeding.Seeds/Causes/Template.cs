using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes
{
    public abstract class Template : EntityTemplate<Cause>
    {
        protected override Cause GetEntity(ISeedBuilder builder)
        {
            Cause cause = GetCause();

            builder.AddTextBlocks(cause, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(cause, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(cause, GetEffects, e => e.EffectId);

            return cause;
        }

        protected abstract Cause GetCause();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
