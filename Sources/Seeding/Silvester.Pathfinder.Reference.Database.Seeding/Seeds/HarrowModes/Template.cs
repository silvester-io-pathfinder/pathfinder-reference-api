using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowModes
{
    public abstract class Template : EntityTemplate<HarrowMode>
    {
        protected override HarrowMode GetEntity(ISeedBuilder builder)
        {
            HarrowMode mode = GetHarrowMode();
            return mode;
        }

        protected abstract HarrowMode GetHarrowMode();
    }
}
