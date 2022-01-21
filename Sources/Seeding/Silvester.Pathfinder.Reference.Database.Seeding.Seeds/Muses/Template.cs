using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Muses
{
    public abstract class Template : EntityTemplate<Muse>
    {
        protected override Muse GetEntity(ISeedBuilder builder)
        {
            Muse muse = GetMuse();

            builder.AddSourcePage(muse, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(muse, GetEffects, e => e.EffectId);

            return muse;
        }

        protected abstract Muse GetMuse();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
    }
}
