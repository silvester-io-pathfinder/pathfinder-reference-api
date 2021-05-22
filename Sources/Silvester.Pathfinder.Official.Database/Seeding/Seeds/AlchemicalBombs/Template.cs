using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs
{
    public abstract class Template : EntityTemplate<AlchemicalBomb>
    {
        protected override AlchemicalBomb GetEntity(ModelBuilder builder)
        {
            AlchemicalBomb bomb = GetAlchemicalBomb();

            builder.AddSourcePage(bomb, GetSourcePage(), e => e.SourcePage);
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
