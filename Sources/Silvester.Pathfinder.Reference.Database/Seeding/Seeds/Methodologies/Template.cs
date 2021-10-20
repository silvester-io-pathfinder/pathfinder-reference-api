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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies
{
    public abstract class Template : EntityTemplate<Methodology>
    {
        protected override Methodology GetEntity(ModelBuilder builder)
        {
            Methodology methodology = GetMethodology();

            builder.AddTextBlocks(methodology, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(methodology, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffects(GetEffects(), (effect) => new MethodologyEffectBinding { MethodologyId = methodology.Id });

            return methodology;
        }

        protected abstract Methodology GetMethodology();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Effect> GetEffects();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
