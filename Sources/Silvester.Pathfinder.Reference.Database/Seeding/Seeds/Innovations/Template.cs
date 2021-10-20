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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Innovations
{
    public abstract class Template : EntityTemplate<Innovation>
    {
        protected override Innovation GetEntity(ModelBuilder builder)
        {
            Innovation innovation = GetInnovation();

            builder.AddSourcePage(innovation, GetSourcePage(), (e) => e.SourcePageId);
            builder.AddTable(innovation, GetTable());
            builder.AddTextBlocks(innovation, GetDetails(), e => e.Details);
            builder.AddEffects(GetEffects(), (e) => new InnovationEffectBinding { InnovationId = innovation.Id });

            return innovation;
        }

        protected abstract Innovation GetInnovation();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Effect> GetEffects();

        protected virtual Table? GetTable()
        {
            return null;
        }
    }
}
