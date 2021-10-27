using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications
{
    public abstract class Template : EntityTemplate<InnovationModification>
    {
        protected override InnovationModification GetEntity(ModelBuilder builder)
        {
            InnovationModification modification = GetInnovationModification();

            builder.AddSourcePage(modification, GetSourcePage(), (e) => e.SourcePageId);
            builder.AddEffect(modification, GetEffects);
            builder.AddPrerequisite(modification, builder => GetPrerequisites(builder, modification));
            
            return modification;
        }

        protected abstract InnovationModification GetInnovationModification();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);

        private void GetPrerequisites(BooleanPrerequisiteBuilder builder, InnovationModification modification)
        {
            builder.HaveSpecificInnovation(modification.Id, modification.InnovationId);
        }
    }
}
