using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts
{
    public abstract class Template : EntityTemplate<Instinct>
    {
        protected override Instinct GetEntity(ModelBuilder builder)
        {
            Instinct instinct = GetInstinct();

            builder.AddSourcePage(instinct, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(GetInstinctAbilityEffect(), new InstinctEffectBinding { InstinctId = instinct.Id });
            builder.AddEffects(GetRagingEffects(), (effect) => new InstinctEffectBinding { InstinctId = instinct.Id });
            builder.AddTable(instinct, GetTable());

            return instinct;
        }

        protected abstract Instinct GetInstinct();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Effect> GetRagingEffects();
        protected abstract Effect GetInstinctAbilityEffect();

        protected virtual Table? GetTable()
        {
            return null;
        }
    }
}
