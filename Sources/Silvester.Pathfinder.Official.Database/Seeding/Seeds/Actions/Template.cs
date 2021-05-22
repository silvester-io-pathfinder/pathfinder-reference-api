using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions
{
    public abstract class Template : EntityTemplate<Models.Action>
    {
        protected override Models.Action GetEntity(ModelBuilder builder)
        {
            Models.Action action = GetAction();

            builder.AddTextBlocks(action, GetDetails(), (a) => a.Details);
            builder.AddRollableEffect(action, GetRollableEffect(), e => e.RollableEffect);
            builder.AddTraits(action, GetTraits());

            return action;
        }

        protected abstract Models.Action GetAction();
        protected abstract IEnumerable<TextBlock> GetDetails();

        protected virtual RollableEffect? GetRollableEffect()
        {
            return null;
        }

        protected virtual IEnumerable<Guid> GetTraits()
        {
            yield break;
        }
    }
}
