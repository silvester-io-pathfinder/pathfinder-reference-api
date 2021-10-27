using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets
{
    public abstract class Template : EntityTemplate<Racket>
    {
        protected override Racket GetEntity(ModelBuilder builder)
        {
            Racket racket = GetRacket();

            builder.AddTextBlocks(racket, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(racket, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(racket, GetEffects);

            return racket;
        }

        protected abstract Racket GetRacket();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
