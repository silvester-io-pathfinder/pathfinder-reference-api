﻿using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups
{
    public abstract class AbstractWeaponGroupTemplate : EntityTemplate<WeaponGroup>
    {
        protected override WeaponGroup GetEntity(ModelBuilder builder)
        {
            WeaponGroup group = GetWeaponGroup();

            SourcePage sourcePage = GetSourcePage();
            group.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            return group;
        }

        protected abstract WeaponGroup GetWeaponGroup();
        protected abstract SourcePage GetSourcePage();
    }
}
