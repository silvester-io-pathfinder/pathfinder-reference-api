using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RangedWeapons
{
    public abstract class Template : EntityTemplate<RangedWeapon>
    {
        protected override RangedWeapon GetEntity(ModelBuilder builder)
        {
            RangedWeapon weapon = GetRangedWeapon();

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, RangedWeapon>((traitId, weapon.Id));
            }

            SourcePage sourcePage = GetSourcePage();
            weapon.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            return weapon;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract RangedWeapon GetRangedWeapon();
    }
}
