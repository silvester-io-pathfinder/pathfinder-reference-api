using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells
{
    public abstract class Template : EntityTemplate<Spell>
    {
        protected override Spell GetEntity(ModelBuilder builder)
        {
            Spell spell = GetSpell();
            
            Table? table = GetTable(new TableBuilder());
            if(table != null)
            {
                spell.TableId = table.Id;
                builder.AddTable(spell, table);
            }

            builder.AddSourcePage(spell, GetSourcePage(), e => e.SourcePage);
            builder.AddTraits(spell, GetTraits());
            builder.AddTextBlocks(spell, GetSpellDetailBlocks(), e => e.Details);
            builder.AddRollableEffects(spell, GetRollableEffects(), e => e.RollableEffects);
            builder.AddActionEffects(spell, GetActionEffects(), e => e.ActionEffects);
            builder.AddStaggeredEffects(spell, GetStaggeredEffects(), e => e.StaggeredEffects);
            builder.HasJoinData<Spell, SpellComponent>(spell, GetSpellComponents());
            builder.HasJoinData<Spell, Creature>(spell, GetSummonedCreatures());

            foreach (SpellHeightening heightening in GetHeightenings())
            {
                builder.AddTextBlocks(heightening, heightening.Details, e => e.Details);
                heightening.Details.Clear();

                heightening.SpellId = spell.Id;
                builder.AddData(heightening);
            }

            return spell;
        }

        protected abstract SourcePage GetSourcePage();
        public abstract Spell GetSpell();
        public abstract IEnumerable<TextBlock> GetSpellDetailBlocks();
        public abstract IEnumerable<Guid> GetSpellComponents();
        public abstract IEnumerable<Guid> GetTraits();

        public virtual IEnumerable<Guid> GetMagicTraditions()
        {
            //Override in concrete subclass to add Magic Traditions.
            yield break;
        }

        protected virtual Table? GetTable(TableBuilder builder)
        {
            return null;
        }

        protected virtual IEnumerable<ActionEffect> GetActionEffects()
        {
            //Override in concrete subclass to add action effects.
            yield break;
        }

        protected virtual IEnumerable<StaggeredEffect> GetStaggeredEffects()
        {
            yield break;
        }

        protected virtual IEnumerable<Guid> GetSummonedCreatures()
        {
            //Override in concrete subclass to add summoned creatures to the effect of the spell.
            yield break;
        }

        public virtual IEnumerable<RollableEffect> GetRollableEffects()
        {
            //Override in concrete subclass to add a rollable effect.
            yield break;
        }

        public virtual IEnumerable<SpellHeightening> GetHeightenings()
        {
            //Override in concrete subclass to add heightened spell effects.
            yield break;
        }
    }
}
