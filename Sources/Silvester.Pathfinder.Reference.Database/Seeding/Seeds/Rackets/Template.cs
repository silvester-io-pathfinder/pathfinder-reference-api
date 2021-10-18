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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets
{
    public abstract class Template : EntityTemplate<Racket>
    {
        protected override Racket GetEntity(ModelBuilder builder)
        {
            Racket racket = GetRacket();

            builder.AddTextBlocks(racket, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(racket, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffects(GetEffects(), (effect) => new RacketEffectBinding { RacketId = racket.Id });

            return racket;
        }

        protected abstract Racket GetRacket();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Effect> GetEffects();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
