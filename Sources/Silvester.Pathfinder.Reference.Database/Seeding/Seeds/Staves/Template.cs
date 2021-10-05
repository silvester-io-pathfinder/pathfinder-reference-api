using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Staves
{
    public abstract class Template : EntityTemplate<Stave>
    {
        protected override Stave GetEntity(ModelBuilder builder)
        {
            Stave stave = GetStave();

            builder.AddSourcePage(stave, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(stave, GetTraits());
            builder.AddTextBlocks(stave, GetDetails(), e => e.Details);
            builder.AddActionEffects(stave, GetActionEffects(), e => e.Effects);

            foreach (StavePotencyBinding potency in GetPotencies())
            {
                potency.StaveId = stave.Id;

                foreach(StaveSpell spell in potency.Spells)
                {
                    spell.PotencyBindingId = potency.Id;
                    builder.AddData(spell);
                }
                potency.Spells = new StaveSpell[0];
                
                builder.AddTraits(potency, GetPotencyTraits(potency));
                builder.AddData(potency);
            }

            return stave;
        }

        protected abstract IEnumerable<StavePotencyBinding> GetPotencies();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<ActionEffect> GetActionEffects();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract SourcePage GetSourcePage();
        protected abstract Stave GetStave();

        protected virtual IEnumerable<Guid> GetPotencyTraits(StavePotencyBinding potency)
        {
            yield break;
        }
    }
}
