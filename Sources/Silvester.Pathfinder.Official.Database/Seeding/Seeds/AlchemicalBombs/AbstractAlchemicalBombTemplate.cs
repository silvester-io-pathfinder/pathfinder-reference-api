using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs
{
    public abstract class AbstractAlchemicalBombTemplate : EntityTemplate<AlchemicalBomb>
    {
        protected override AlchemicalBomb GetEntity(ModelBuilder builder)
        {
            AlchemicalBomb bomb = GetAlchemicalBomb();

            SourcePage? sourcePage = GetSourcePage();
            if (sourcePage != null)
            {
                builder.AddData(sourcePage);
                bomb.SourcePageId = sourcePage.Id;
            }

            builder.AddTextBlocks(bomb, GetDetailBlocks(), e => e.Details);

            foreach (AlchemicalBombPotencyBinding potency in GetPotencies())
            {
                potency.AlchemicalBombId = bomb.Id;
                builder.AddData(potency);
            }

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, AlchemicalBomb>((traitId, bomb.Id));
            }

            return bomb;
        }

        protected abstract AlchemicalBomb GetAlchemicalBomb();
        protected abstract SourcePage? GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract IEnumerable<AlchemicalBombPotencyBinding> GetPotencies();
    }
}
