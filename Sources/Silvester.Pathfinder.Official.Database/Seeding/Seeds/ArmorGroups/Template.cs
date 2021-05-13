using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups
{
    public abstract class Template : EntityTemplate<ArmorGroup>
    {
        protected override ArmorGroup GetEntity(ModelBuilder builder)
        {
            ArmorGroup group = GetArmorGroup();

            SourcePage sourcePage = GetSourcePage();
            group.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            return group;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract ArmorGroup GetArmorGroup();
    }
}
