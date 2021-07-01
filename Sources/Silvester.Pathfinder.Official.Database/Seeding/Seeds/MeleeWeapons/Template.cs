using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons
{
    public abstract class Template : EntityTemplate<MeleeWeapon>
    {
        protected override MeleeWeapon GetEntity(ModelBuilder builder)
        {
            MeleeWeapon weapon = GetMeleeWeapon();

            builder.AddSourcePage(weapon, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(weapon, GetTraits());

            return weapon;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract MeleeWeapon GetMeleeWeapon();
    }
}
