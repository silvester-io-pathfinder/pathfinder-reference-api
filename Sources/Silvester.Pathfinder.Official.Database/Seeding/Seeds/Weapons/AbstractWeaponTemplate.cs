using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Weapons
{
    public abstract class AbstractWeaponTemplate : EntityTemplate<Weapon>
    {
        protected override Weapon GetEntity(ModelBuilder builder)
        {
            Weapon weapon = GetWeapon();

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, Weapon>((traitId, weapon.Id));
            }

            SourcePage sourcePage = GetSourcePage();
            weapon.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            return weapon;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract Weapon GetWeapon();
    }
}
