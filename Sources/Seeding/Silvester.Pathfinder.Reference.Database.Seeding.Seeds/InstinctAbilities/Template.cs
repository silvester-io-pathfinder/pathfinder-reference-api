using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities
{
    public abstract class Template : EntityTemplate<InstinctAbility>
    {
        protected override InstinctAbility GetEntity(ISeedBuilder builder)
        {
            InstinctAbility instinct = GetInstinctAbility();

            builder.AddSourcePage(instinct, GetSourcePage(), (e => e.SourcePageId));
            builder.AddTable(instinct, GetTable());

            return instinct;
        }

        protected abstract InstinctAbility GetInstinctAbility();
        protected abstract SourcePage GetSourcePage();

        protected virtual Table? GetTable()
        {
            return null;
        }
    }
}
