using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons
{
    public abstract class Template : EntityTemplate<PreciousMaterialWeapon>
    {
        protected override PreciousMaterialWeapon GetEntity(ModelBuilder builder)
        {
            PreciousMaterialWeapon weapon = GetWeapon();

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<PreciousMaterialWeapon, Trait>((weapon.Id, traitId));
            }

            builder.AddTextBlocks(weapon, GetDetails(), e => e.Details);

            SourcePage sourcePage = GetSourcePage();
            weapon.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            foreach(PreciousMaterialWeaponVariant variant in GetVariants())
            {
                variant.WeaponId = weapon.Id;
                builder.AddData(variant);
            }

            return weapon;
        }

        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract SourcePage GetSourcePage();
        protected abstract PreciousMaterialWeapon GetWeapon();
        protected abstract IEnumerable<PreciousMaterialWeaponVariant> GetVariants();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
