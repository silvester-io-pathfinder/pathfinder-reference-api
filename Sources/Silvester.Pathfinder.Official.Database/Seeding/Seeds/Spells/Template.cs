using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
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
            
            RollableEffect? effect = GetRollableEffect();
            if(effect != null)
            {
                builder.AddData(effect); 
                spell.RollableEffectId = effect.Id;
            }

            builder.AddTextBlocks(spell, GetSpellDetailBlocks(), e => e.Details);

            foreach (Guid traditionId in GetMagicTraditions())
            {
                builder.HasJoinData<MagicTradition, Spell>((traditionId, spell.Id));
            }
            
            foreach (Guid spellComponentId in GetSpellComponents())
            {
                builder.HasJoinData<SpellComponent, Spell>((spellComponentId, spell.Id));
            }

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, Spell>((traitId, spell.Id));
            }

            foreach (SpellHeightening heightening in GetHeightenings())
            {
                builder.AddTextBlocks(heightening, heightening.Details, e => e.Details);
                heightening.Details.Clear();

                heightening.SpellId = spell.Id;
                builder.AddData(heightening);
            }

            foreach (SpellTrigger trigger in GetTriggers())
            {
                builder.AddData(trigger);
                trigger.SpellId = spell.Id;
            }

            foreach (SpellRequirement requirement in GetRequirements())
            {
                builder.AddData(requirement);
                requirement.SpellId = spell.Id;
            }

            return spell;
        }

        public abstract Spell GetSpell();
        public abstract IEnumerable<TextBlock> GetSpellDetailBlocks();
        public abstract IEnumerable<Guid> GetSpellComponents();
        public abstract IEnumerable<Guid> GetTraits();
        public abstract IEnumerable<Guid> GetMagicTraditions();

        public virtual RollableEffect? GetRollableEffect()
        {
            //Override in concrete subclass to add a rollable effect.
            return null;
        }


        public virtual IEnumerable<SpellHeightening> GetHeightenings()
        {
            //Override in concrete subclass to add heightened spell effects.
            yield break;
        }

        public virtual IEnumerable<SpellTrigger> GetTriggers()
        {
            //Override in concrete subclass to add trigger conditions.
            yield break;
        }

        public virtual IEnumerable<SpellRequirement> GetRequirements()
        {
            //Override in concrete subclass to add requirement prerequisites.
            yield break;
        }
    }
}
