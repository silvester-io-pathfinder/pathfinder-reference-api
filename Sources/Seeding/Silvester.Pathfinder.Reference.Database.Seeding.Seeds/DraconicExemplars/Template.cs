using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DraconicExemplars
{
    public abstract class Template : EntityTemplate<DraconicExemplar>
    {
        protected override DraconicExemplar GetEntity(ISeedBuilder builder)
        {
            DraconicExemplar exemplar = GetDraconicExemplar();

            builder.AddSourcePage(exemplar, GetSourcePage(), (e => e.SourcePageId));

            return exemplar;
        }

        protected abstract DraconicExemplar GetDraconicExemplar();
        protected abstract SourcePage GetSourcePage();
    }
}
