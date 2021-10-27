using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HuntersEdges
{
    public abstract class Template : EntityTemplate<HuntersEdge>
    {
        protected override HuntersEdge GetEntity(ModelBuilder builder)
        {
            HuntersEdge edge = GetHuntersEdge();

            builder.AddSourcePage(edge, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(edge, GetEffects);

            return edge;
        }

        protected abstract HuntersEdge GetHuntersEdge();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
    }
}
