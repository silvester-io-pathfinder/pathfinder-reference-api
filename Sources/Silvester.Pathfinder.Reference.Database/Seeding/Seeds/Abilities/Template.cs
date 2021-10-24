using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities
{
    public abstract class Template : EntityTemplate<Ability>
    {
        protected override Ability GetEntity(ModelBuilder builder)
        {
            Ability ability = GetAbility();

            builder.AddTextBlocks(ability, GetEffects(), (a) => a.Effects);
            builder.AddSourcePage(ability, GetSourcePage(), (e) => e.SourcePageId);
            builder.AddTraits(ability, GetTraits());
            builder.AddRollableEffect(ability, GetRollableEffect(), e => e.RollableEffect);

            return ability;
        }

        protected abstract IEnumerable<TextBlock> GetEffects();
        protected abstract Ability GetAbility();
        protected abstract SourcePage GetSourcePage();

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
