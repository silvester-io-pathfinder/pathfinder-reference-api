using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Focusses
{
    public abstract class Template : EntityTemplate<Focus>
    {
        protected override Focus GetEntity(ModelBuilder builder)
        {
            Focus focus = GetFocus();

            RollableEffect? rollableEffect = GetRollableEffect();
            if (rollableEffect != null)
            {
                builder.AddData(rollableEffect);
                focus.RollableEffectId = rollableEffect.Id;
            }

            Table? table = GetTable(new TableBuilder());
            if (table != null)
            {
                focus.TableId = table.Id;
                builder.AddTable(table);
            }

            SourcePage sourcePage = GetSourcePage();
            focus.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            builder.AddTextBlocks(focus, GetDetailBlocks(), e => e.Details);

            foreach (Guid spellComponentId in GetSpellComponents())
            {
                builder.HasJoinData<SpellComponent, Spell>((spellComponentId, focus.Id));
            }

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, Spell>((traitId, focus.Id));
            }

            foreach (Guid creatureId in GetSummonedCreatures())
            {
                builder.HasJoinData<Creature, Spell>((creatureId, focus.Id));
            }

            foreach (FocusHeightening heightening in GetHeightenings())
            {
                builder.AddTextBlocks(heightening, heightening.Details, e => e.Details);
                heightening.Details.Clear();

                heightening.FocusId = focus.Id;
                builder.AddData(heightening);
            }

            foreach (StaggeredEffect effect in GetStaggeredEffects())
            {
                foreach (StaggeredEffectStage stage in effect.Stages)
                {
                    stage.StaggeredEffectId = effect.Id;
                    foreach (StaggeredEffectStageEffect stageEffect in stage.Effects)
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

            foreach (ActionEffect effect in GetActionEffects())
            {
                builder.AddOwnedData<Spell, ActionEffect>(e => e.ActionEffects, effect);
            }

            return focus;
        }

        protected abstract SourcePage GetSourcePage();
        public abstract Focus GetFocus();
        public abstract IEnumerable<TextBlock> GetDetailBlocks();
        public abstract IEnumerable<Guid> GetSpellComponents();
        public abstract IEnumerable<Guid> GetTraits();

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

        public virtual RollableEffect? GetRollableEffect()
        {
            //Override in concrete subclass to add a rollable effect.
            return null;
        }

        public virtual IEnumerable<FocusHeightening> GetHeightenings()
        {
            //Override in concrete subclass to add heightened spell effects.
            yield break;
        }
    }
}
