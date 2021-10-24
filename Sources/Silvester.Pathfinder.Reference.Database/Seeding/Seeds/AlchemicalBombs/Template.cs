using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalBombs
{
    public abstract class Template : EntityTemplate<AlchemicalBomb>
    {
        protected override AlchemicalBomb GetEntity(ModelBuilder builder)
        {
            AlchemicalBomb bomb = GetAlchemicalBomb();

            builder.AddSourcePage(bomb, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(bomb, GetDetailBlocks(), e => e.Details);
            builder.AddTraits(bomb, GetTraits());

            foreach (AlchemicalBombPotencyBinding potency in GetPotencies())
            {
                potency.AlchemicalBombId = bomb.Id;
                builder.AddData(potency);
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
