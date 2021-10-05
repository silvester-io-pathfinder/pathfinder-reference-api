using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities
{
    public abstract class Template : EntityTemplate<Ability>
    {
        protected override Ability GetEntity(ModelBuilder builder)
        {
            Ability ability = GetAbility();

            builder.AddSourcePage(ability, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(ability, GetDetailBlocks(), (c) => c.Details);
            builder.AddTraits(ability, GetTraits());

            return ability;
        }

        public abstract Ability GetAbility();
        public abstract SourcePage GetSourcePage();
        public abstract IEnumerable<TextBlock> GetDetailBlocks();

        public virtual IEnumerable<Guid> GetTraits()
        {
            yield break;
        }
    }
}
