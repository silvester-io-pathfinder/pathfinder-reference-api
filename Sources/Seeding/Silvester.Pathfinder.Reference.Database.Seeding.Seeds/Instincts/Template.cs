using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts
{
    public abstract class Template : EntityTemplate<Instinct>
    {
        protected override Instinct GetEntity(ISeedBuilder builder)
        {
            Instinct instinct = GetInstinct();

            builder.AddSourcePage(instinct, GetSourcePage(), e => e.SourcePageId);
            builder.AddEffect(instinct, GetInstinctAbilityEffects, e => e.InstinctAbilityEffectId);
            builder.AddEffect(instinct, GetRagingEffects, e => e.RagingEffectId, overrideId: GetSourcePage().Id);
            builder.AddTable(instinct, GetTable(), e => e.TableId);

            return instinct;
        }

        protected abstract Instinct GetInstinct();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetRagingEffects(BooleanEffectBuilder builder);
        protected abstract void GetInstinctAbilityEffects(BooleanEffectBuilder builder);

        protected virtual Table? GetTable()
        {
            return null;
        }
    }
}
