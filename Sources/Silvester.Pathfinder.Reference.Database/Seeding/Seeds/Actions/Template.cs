using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions
{
    public abstract class Template : EntityTemplate<Models.Entities.Action>
    {
        protected override Models.Entities.Action GetEntity(ModelBuilder builder)
        {
            Models.Entities.Action action = GetAction();

            builder.AddTextBlocks(action, GetDetails(), (a) => a.Details);
            builder.AddRollableEffect(action, GetRollableEffect(), e => e.RollableEffect);
            builder.AddTraits(action, GetTraits());

            return action;
        }

        protected abstract Models.Entities.Action GetAction();
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
