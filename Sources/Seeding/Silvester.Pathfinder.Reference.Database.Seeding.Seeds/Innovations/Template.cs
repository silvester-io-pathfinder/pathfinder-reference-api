using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Innovations
{
    public abstract class Template : EntityTemplate<Innovation>
    {
        protected override Innovation GetEntity(ISeedBuilder builder)
        {
            Innovation innovation = GetInnovation();

            builder.AddSourcePage(innovation, GetSourcePage(), (e) => e.SourcePageId);
            builder.AddTable(innovation, GetTable());
            builder.AddTextBlocks(innovation, GetDetails(), e => e.Details);
            builder.AddEffect(innovation, GetEffects, e => e.EffectId);

            return innovation;
        }

        protected abstract Innovation GetInnovation();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract void GetEffects(BooleanEffectBuilder builder);

        protected virtual Table? GetTable()
        {
            return null;
        }
    }
}
