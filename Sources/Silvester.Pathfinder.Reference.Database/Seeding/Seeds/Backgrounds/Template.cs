using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

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
            builder.AddEffects(GetEffects(), (effect) => new BackgroundEffectBinding { BackgroundId = background.Id});
            builder.AddPrerequisites(GetPrerequisites(), () => new BackgroundPrerequisiteBinding { BackgroundId = background.Id });

            return background;
        }

        protected abstract Background GetBackground();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Effect> GetEffects();
        protected abstract SourcePage GetSourcePage();

        protected virtual IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield break;
        }

        protected virtual IEnumerable<Guid> GetTraits()
        {
            yield break;
        }
    }
}
