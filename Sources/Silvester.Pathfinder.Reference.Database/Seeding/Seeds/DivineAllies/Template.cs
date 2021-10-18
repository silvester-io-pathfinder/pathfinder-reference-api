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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineAllies
{
    public abstract class Template : EntityTemplate<DivineAlly>
    {
        protected override DivineAlly GetEntity(ModelBuilder builder)
        {
            DivineAlly ally = GetDivineAlly();

            builder.AddSourcePage(ally, GetSourcePage(), (e => e.SourcePageId));

            return ally;
        }

        protected abstract DivineAlly GetDivineAlly();
        protected abstract SourcePage GetSourcePage();
    }
}
