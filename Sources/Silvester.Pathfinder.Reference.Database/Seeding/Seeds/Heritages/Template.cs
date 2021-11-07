using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages
{
    public abstract class Template : EntityTemplate<Heritage>
    {
        protected override Heritage GetEntity(ModelBuilder builder)
        {
            Heritage heritage = GetHeritage();

            builder.HasJoinData<Heritage, Ancestry>(heritage, GetAncestries());
            builder.AddSourcePage(heritage, GetSourcePage(), e => e.SourcePageId);
            builder.AddEffect(heritage, GetEffects);
            builder.AddTextBlocks(heritage, GetDetails(), e => e.Details);

            return heritage;
        }

        protected abstract Heritage GetHeritage();
        protected abstract IEnumerable<Guid> GetAncestries();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
    }
}
