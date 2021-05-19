using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Abilities
{
    public abstract class Template : EntityTemplate<Ability>
    {
        protected override Ability GetEntity(ModelBuilder builder)
        {
            Ability ability = GetAbility();

            SourcePage sourcePage = GetSourcePage();
            builder.AddData(sourcePage);
            ability.SourcePageId = sourcePage.Id;

            builder.AddTextBlocks(ability, GetDetailBlocks(), (c) => c.Details);

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Ability, Trait>((ability.Id, traitId));
            }

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
