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

            builder.AddSourcePage(rune, GetSourcePage(), e => e.SourcePage);
            builder.AddTraits(rune, GetTraits());

            foreach (WeaponPropertyRuneAction action in GetActions())
            {
                action.RuneId = rune.Id;
                builder.AddData(action);

                foreach (Guid traitId in GetActionTraits(action))
                {
                    builder.HasJoinData<WeaponPropertyRuneAction, Trait>((action.Id, traitId));
                }
            }

            foreach(WeaponPropertyRunePotencyBinding potency in GetPotencies())
            {
                potency.RuneId = rune.Id;

                if(potency.RollableEffect != null)
                {
                    builder.AddData(potency.RollableEffect);
                    potency.RollableEffectId = potency.RollableEffect.Id;
                    potency.RollableEffect = null;
                }

                builder.AddTraits(potency, GetPotencyTraits(potency));
                builder.AddTextBlocks(potency, potency.Benefits, e => e.Benefits);
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
