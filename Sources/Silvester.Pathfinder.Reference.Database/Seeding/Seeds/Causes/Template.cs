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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes
{
    public abstract class Template : EntityTemplate<Cause>
    {
        protected override Cause GetEntity(ModelBuilder builder)
        {
            Cause cause = GetCause();

            builder.AddTextBlocks(cause, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(cause, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffects(GetEffects(), (effect) => new CauseEffectBinding { CauseId = cause.Id });

            return cause;
        }

        protected abstract Cause GetCause();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Effect> GetEffects();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
