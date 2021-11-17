using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Curses
{
    public abstract class Template : EntityTemplate<Curse>
    {
        protected override Curse GetEntity(ISeedBuilder builder)
        {
            Curse curse = GetCurse();

            builder.AddSourcePage(curse, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(curse, GetTraits());
            builder.AddTextBlocks(curse, GetDetailBlocks(), (c) => c.Details);

            return curse;
        }

        public abstract Curse GetCurse();
        public abstract SourcePage GetSourcePage();
        public abstract IEnumerable<TextBlock> GetDetailBlocks();
        public abstract IEnumerable<Guid> GetTraits();
    }
}
