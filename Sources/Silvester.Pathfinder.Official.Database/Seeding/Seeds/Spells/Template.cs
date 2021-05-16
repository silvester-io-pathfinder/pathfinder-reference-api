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
            
            RollableEffect? rollableEffect = GetRollableEffect();
            if(rollableEffect != null)
            {
                builder.AddData(rollableEffect); 
                spell.RollableEffectId = rollableEffect.Id;
            }

            SourcePage sourcePage = GetSourcePage();
            spell.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

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

            foreach (StaggeredEffect effect in GetStaggeredEffects())
            {
                foreach(StaggeredEffectStage stage in effect.Stages)
                {
                    stage.StaggeredEffectId = effect.Id;
                    foreach(StaggeredEffectStageEffect stageEffect in stage.Effects)
                    {
                        stageEffect.StaggeredEffectStageId = stage.Id;
                        builder.AddData(stageEffect);
                    }
                
                    stage.Effects = new StaggeredEffectStageEffect[0];
                    builder.AddData(stage);
                }
                
                effect.Stages = new StaggeredEffectStage[0];
                builder.AddData(effect);
            }

            foreach(ActionEffect effect in GetActionEffects())
            {
                builder.AddOwnedData<Spell, ActionEffect>(e => e.ActionEffects, effect);
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

        protected abstract IEnumerable<ActionEffect> GetActionEffects();
        protected abstract SourcePage GetSourcePage();
        public abstract Spell GetSpell();
        public abstract IEnumerable<TextBlock> GetSpellDetailBlocks();
        public abstract IEnumerable<Guid> GetSpellComponents();
        public abstract IEnumerable<Guid> GetTraits();
        public abstract IEnumerable<Guid> GetMagicTraditions();
        
        protected virtual IEnumerable<StaggeredEffect> GetStaggeredEffects()
        {
            //Override in concrete subclass to add staggered effects.
            yield break;
        }

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
