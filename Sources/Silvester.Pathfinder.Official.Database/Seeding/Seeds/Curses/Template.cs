using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Curses
{
    public abstract class Template : EntityTemplate<Curse>
    {
        protected override Curse GetEntity(ModelBuilder builder)
        {
            Curse curse = GetCurse();

            SourcePage sourcePage = GetSourcePage();
            builder.AddData(sourcePage);
            curse.SourcePageId = sourcePage.Id;

            builder.AddTextBlocks(curse, GetDetailBlocks(), (c) => c.Details);

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Curse, Trait>((curse.Id, traitId));
            }

            return curse;
        }

        public abstract Curse GetCurse();
        public abstract SourcePage GetSourcePage();
        public abstract IEnumerable<TextBlock> GetDetailBlocks();
        public abstract IEnumerable<Guid> GetTraits();
    }
}
