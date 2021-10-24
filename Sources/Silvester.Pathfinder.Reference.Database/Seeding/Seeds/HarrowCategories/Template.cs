using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCategories
{
    public abstract class Template : EntityTemplate<HarrowCategory>
    {
        protected override HarrowCategory GetEntity(ModelBuilder builder)
        {
            HarrowCategory harrow = GetHarrow();
            return harrow;
        }

        protected abstract HarrowCategory GetHarrow();
    }
}
