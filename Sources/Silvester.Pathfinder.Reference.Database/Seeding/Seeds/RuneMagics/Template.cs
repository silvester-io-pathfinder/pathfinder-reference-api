using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RuneMagics
{
    public abstract class Template : EntityTemplate<RuneMagic>
    {
        protected override RuneMagic GetEntity(ModelBuilder builder)
        {
            RuneMagic runeMagic = GetRuneMagic();

            builder.AddSourcePage(runeMagic, GetSourcePage(), (e => e.SourcePageId));
            builder.HasJoinData<RuneMagic, MagicSchool>(GetProhibitedMagicSchools().Select(schoolId => (runeMagic.Id, schoolId)));
            builder.AddEffect(runeMagic, GetEffects);

            return runeMagic;
        }

        protected abstract RuneMagic GetRuneMagic();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract IEnumerable<Guid> GetProhibitedMagicSchools();
    }
}
