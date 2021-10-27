using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SwashbucklerStyles
{
    public abstract class Template : EntityTemplate<SwashbucklersStyle>
    {
        protected override SwashbucklersStyle GetEntity(ModelBuilder builder)
        {
            SwashbucklersStyle style = GetSwashbucklersStyle();

            builder.AddSourcePage(style, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(style, GetEffects);

            return style;
        }

        protected abstract SwashbucklersStyle GetSwashbucklersStyle();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
    }
}
