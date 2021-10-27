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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PatronThemes
{
    public abstract class Template : EntityTemplate<PatronTheme>
    {
        protected override PatronTheme GetEntity(ModelBuilder builder)
        {
            PatronTheme theme = GetPatronTheme();

            builder.AddSourcePage(theme, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(theme, GetEffects);
            builder.HasJoinData<PatronTheme, Spell>(GetGrantedSpellOptions().Select(spellId => (theme.Id, spellId)));

            return theme;
        }

        protected abstract PatronTheme GetPatronTheme();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract IEnumerable<Guid> GetGrantedSpellOptions();
    }
}
