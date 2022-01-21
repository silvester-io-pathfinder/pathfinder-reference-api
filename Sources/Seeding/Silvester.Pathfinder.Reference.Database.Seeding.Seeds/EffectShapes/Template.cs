using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.EffectShapes
{
    public abstract class Template : EntityTemplate<EffectShape>
    {
        protected override EffectShape GetEntity(ISeedBuilder builder)
        {
            EffectShape shape = GetEffectShape();
            return shape;
        }

        protected abstract EffectShape GetEffectShape();
    }
}
