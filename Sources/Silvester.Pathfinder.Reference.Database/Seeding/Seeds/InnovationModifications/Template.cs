using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications
{
    public abstract class Template : EntityTemplate<InnovationModification>
    {
        protected override InnovationModification GetEntity(ModelBuilder builder)
        {
            InnovationModification modification = GetInnovationModification();

            builder.AddSourcePage(modification, GetSourcePage(), (e) => e.SourcePageId);
            builder.AddEffects(GetEffects(), (e) => new InnovationModificationEffectBinding { InnovationModificationId = modification.Id });
            builder.AddPrerequisites(GetPrerequisites(modification), () => new InnovationModificationPrerequisiteBinding { InnovationModificationId = modification.Id });
            
            return modification;
        }

        protected abstract InnovationModification GetInnovationModification();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Effect> GetEffects();

        private IEnumerable<Prerequisite> GetPrerequisites(InnovationModification modification)
        {
            yield return new HaveSpecificInnovationPrerequisite { Id = modification.Id, InnovationId = modification.InnovationId };
        }
    }
}
