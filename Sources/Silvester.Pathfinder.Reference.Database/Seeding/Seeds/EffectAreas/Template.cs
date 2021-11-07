using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.EffectAreas
{
    public abstract class Template : EntityTemplate<EffectArea>
    {
        protected override EffectArea GetEntity(ModelBuilder builder)
        {
            EffectArea area = GetEffectArea();
            return area;
        }

        protected abstract EffectArea GetEffectArea();
    }
}
