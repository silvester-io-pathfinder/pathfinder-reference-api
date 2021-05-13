using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons
{
    public abstract class Template : EntityTemplate<MeleeWeapon>
    {
        protected override MeleeWeapon GetEntity(ModelBuilder builder)
        {
            MeleeWeapon weapon = GetMeleeWeapon();

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, MeleeWeapon>((traitId, weapon.Id));
            }

            SourcePage sourcePage = GetSourcePage();
            weapon.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            return weapon;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract MeleeWeapon GetMeleeWeapon();
    }
}
