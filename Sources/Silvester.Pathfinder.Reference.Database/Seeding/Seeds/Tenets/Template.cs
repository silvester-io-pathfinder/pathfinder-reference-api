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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Tenets
{
    public abstract class Template : EntityTemplate<Tenet>
    {
        protected override Tenet GetEntity(ModelBuilder builder)
        {
            Tenet tenet = GetTenet();

            builder.AddTextBlocks(tenet, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(tenet, GetSourcePage(), (e => e.SourcePageId));

            return tenet;
        }

        protected abstract Tenet GetTenet();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
