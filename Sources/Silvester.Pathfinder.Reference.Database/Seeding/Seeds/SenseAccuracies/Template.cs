using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SenseAccuracies
{
    public abstract class Template : EntityTemplate<SenseAccuracy>
    {
        protected override SenseAccuracy GetEntity(ModelBuilder builder)
        {
            SenseAccuracy accuracy = GetSenseAccuracy();

            builder.AddSourcePage(accuracy, GetSourcePage(), (e => e.SourcePageId));

            return accuracy;
        }

        protected abstract SenseAccuracy GetSenseAccuracy();
        protected abstract SourcePage GetSourcePage();
    }
}
