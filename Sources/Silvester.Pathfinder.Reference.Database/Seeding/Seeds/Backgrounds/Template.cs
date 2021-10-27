using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds
{
    public abstract class Template : EntityTemplate<Background>
    {
        protected override Background GetEntity(ModelBuilder builder)
        {
            Background background = GetBackground();
            
            builder.AddSourcePage(background, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(background, GetTraits());
            builder.AddTextBlocks(background, GetDetails(), e => e.Details);
            builder.AddEffect(background, GetEffects);
            builder.AddPrerequisite(background, GetPrerequisites);

            return background;
        }

        protected abstract Background GetBackground();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract SourcePage GetSourcePage();

        protected virtual void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        {

        }

        protected virtual IEnumerable<Guid> GetTraits()
        {
            yield break;
        }
    }
}
