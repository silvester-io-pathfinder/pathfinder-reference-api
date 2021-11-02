﻿using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificTenetPrerequisite : BasePrerequisite
    {
        public Guid RequiredTennetId { get; set; }
        public Tenet RequiredTennet { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificTenet(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredTennetId)
        {
            return builder.Add(new HaveSpecificTenetPrerequisite  { Id = id, RequiredTennetId = requiredTennetId });
        }
    }
}
