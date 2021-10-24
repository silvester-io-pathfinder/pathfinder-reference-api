using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons
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
