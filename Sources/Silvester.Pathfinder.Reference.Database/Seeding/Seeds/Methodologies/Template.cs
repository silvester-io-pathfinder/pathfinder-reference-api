using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies
{
    public abstract class Template : EntityTemplate<Methodology>
    {
        protected override Methodology GetEntity(ModelBuilder builder)
        {
            Methodology methodology = GetMethodology();

            builder.AddTextBlocks(methodology, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(methodology, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(methodology, GetEffects, methodology => methodology.EffectId);

            return methodology;
        }

        protected abstract Methodology GetMethodology();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
