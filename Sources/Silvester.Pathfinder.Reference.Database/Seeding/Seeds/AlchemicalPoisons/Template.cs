using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons
{
    public abstract class Template : EntityTemplate<AlchemicalPoison>
    {
        protected override AlchemicalPoison GetEntity(ModelBuilder builder)
        {
            AlchemicalPoison poison = GetAlchemicalPoison();

            StaggeredEffect effect = GetPoisonEffect();
            effect.Stages = GetAlchemicalPoisonStages().ToArray();

            builder.AddStaggeredEffect(poison, effect, e => e.EffectId);
            builder.AddSourcePage(poison, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(poison, GetTraits());
            builder.AddTextBlocks(poison, GetDetailBlocks(), e => e.Details);

            return poison;
        }

        protected abstract AlchemicalPoison GetAlchemicalPoison();
        protected abstract StaggeredEffect GetPoisonEffect();
        protected abstract SourcePage? GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages();
    }
}
