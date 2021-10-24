using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModificationTypes
{
    public abstract class Template : EntityTemplate<InnovationModificationType>
    {
        protected override InnovationModificationType GetEntity(ModelBuilder builder)
        {
            InnovationModificationType type = GetInnovationModificationType();
            return type;
        }

        protected abstract InnovationModificationType GetInnovationModificationType();
    }
}
