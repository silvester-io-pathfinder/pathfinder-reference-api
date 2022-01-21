using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Activities
{
    public abstract class Template : EntityTemplate<Activity>
    {
        protected override Activity GetEntity(ISeedBuilder builder)
        {
            Activity activity = GetActivity();

            builder.AddTextBlocks(activity, GetDetails(), (e) => e.Details);
            builder.AddTraits(activity, GetTraits());
            builder.AddSourcePage(activity, GetSourcePage(), (e => e.SourcePageId));

            return activity;
        }

        protected abstract Activity GetActivity();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Guid> GetTraits();
    }
}
