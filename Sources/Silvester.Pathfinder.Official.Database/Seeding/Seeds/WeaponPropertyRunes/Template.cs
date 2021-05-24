using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes
{
    public abstract class Template : EntityTemplate<WeaponPropertyRune>
    {
        protected override WeaponPropertyRune GetEntity(ModelBuilder builder)
        {
            WeaponPropertyRune rune = GetRune();

            builder.AddSourcePage(rune, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(rune, GetTraits());

            foreach (WeaponPropertyRuneAction action in GetActions())
            {
                action.RuneId = rune.Id;
                builder.AddData(action);
                builder.AddTraits(action, GetActionTraits(action));
            }

            foreach(WeaponPropertyRunePotencyBinding potency in GetPotencies())
            {
                builder.AddTraits(potency, GetPotencyTraits(potency));
                builder.AddTextBlocks(potency, potency.Benefits, e => e.Benefits);
                builder.AddRollableEffect(potency, potency.RollableEffect, e => e.RollableEffect);

                potency.RuneId = rune.Id;
                potency.RollableEffect = null;
                potency.Benefits = new TextBlock[0];

                builder.AddData(potency);
            }

            return rune;
        }

        protected abstract IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract SourcePage GetSourcePage();
        protected abstract WeaponPropertyRune GetRune();

        protected virtual IEnumerable<Guid> GetActionTraits(WeaponPropertyRuneAction action)
        {
            yield break;
        }

        protected virtual IEnumerable<Guid> GetPotencyTraits(WeaponPropertyRunePotencyBinding potency)
        {
            yield break;
        }

        protected virtual IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield break;
        }
    }
}
