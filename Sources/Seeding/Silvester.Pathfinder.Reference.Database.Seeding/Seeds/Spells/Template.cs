using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells
{
    public abstract class Template : EntityTemplate<Spell>
    {
        protected override Spell GetEntity(ISeedBuilder builder)
        {
            Spell spell = GetSpell();
            Table? table = GetTable(new TableBuilder());

            builder.AddTable(spell, table);
            builder.AddSourcePage(spell, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(spell, GetTraits());
            builder.AddTextBlocks(spell, GetSpellDetailBlocks(), e => e.Details);
            builder.AddRollableEffects(spell, GetRollableEffects());
            builder.AddActionEffects(spell, GetActionEffects(), e => e.ActionEffects);
            builder.AddStaggeredEffect(spell, GetStaggeredEffect(), e => e.StaggeredEffectId);
            builder.AddJoinData<Spell, SpellComponent>(spell, GetSpellComponents());
            builder.AddJoinData<Spell, Creature>(spell, GetSummonedCreatures());

            foreach (SpellHeightening heightening in GetHeightenings())
            {
                builder.AddTextBlocks(heightening, heightening.Details, e => e.Details);
             
                heightening.Details = new TextBlock[0];
                heightening.SpellId = spell.Id;
              
                builder.AddData(heightening);
            }

            spell.TableId = table?.Id;
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

        protected virtual StaggeredEffect? GetStaggeredEffect()
        {
            return null;
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
