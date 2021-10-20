using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Extensions
{
    public static class SeedingExtensions
    {
        public static void AddTable<TOwner>(this ModelBuilder builder, TOwner owner, Table? table)
            where TOwner : BaseEntity
        {
            if(table == null)
            {
                return;
            }

            table.OwnerId = owner.Id;

            for(int iColumn = 0; iColumn < table.Columns.Count(); iColumn ++)
            {
                Column column = table.Columns.ElementAt(iColumn);
                column.Order = iColumn;
                column.TableId = table.Id;
                builder.AddData(column);
            }

            for(int iRow = 0; iRow < table.Rows.Count(); iRow ++)
            {
                Row row = table.Rows.ElementAt(iRow);

                for(int iCell = 0; iCell < row.Cells.Count(); iCell ++)
                {
                    Cell cell = row.Cells.ElementAt(iCell);
                    cell.RowId = row.Id;
                    cell.Order = iCell;
                    builder.AddData(cell);
                }
                
                row.TableId = table.Id;
                row.Order = iRow;
                row.Cells = new Cell[0];
                
                builder.AddData(row);
            }

            table.Rows = new Row[0];
            table.Columns = new Column[0];
            
            builder.AddData(table);
        }

        public static void AddStaggeredEffect<TOwner>(this ModelBuilder builder, TOwner owner, StaggeredEffect? effect, Expression<Func<TOwner, Guid?>> keySelector)
            where TOwner : BaseEntity
        {
            if (effect == null)
            {
                return;
            }

            keySelector.SetProperty(owner, effect.Id);
            StaggeredEffectStage[] stages = effect.Stages.ToArray();
            for (int i = 0; i < stages.Length; i++)
            {
                StaggeredEffectStage stage = stages[i];
                stage.StaggeredEffectId = effect.Id;
                stage.Stage = i + 1;

                foreach (StaggeredEffectStageEffect stageEffect in stage.Effects)
                {
                    stageEffect.StaggeredEffectStageId = stage.Id;
                    builder.AddData(stageEffect.GetType(), stageEffect);
                }

                stage.Effects = new StaggeredEffectStageEffect[] { };
                builder.AddData(stage);
            }

            effect.Stages = new StaggeredEffectStage[0];
            builder.AddData(effect);
        }

        public static void AddSourcePage<TOwner>(this ModelBuilder builder, TOwner owner, SourcePage? sourcePage, Expression<Func<TOwner, Guid?>> keySelector)
            where TOwner : BaseEntity
        {
            if(sourcePage != null)
            {
                sourcePage.OwnerId = owner.Id;
                keySelector.SetProperty(owner, sourcePage.Id);
                builder.AddData(sourcePage);
            }
        }

        public static void AddRollableEffect<TOwner>(this ModelBuilder builder, TOwner owner, RollableEffect? effect, Expression<Func<TOwner, RollableEffect?>> selector)
          where TOwner : BaseEntity
        {
            if (effect != null)
            {
                effect.OwnerId = owner.Id;
                builder.AddData(effect);
            }
        }

        public static void AddRollableEffects<TOwner>(this ModelBuilder builder, TOwner owner, IEnumerable<RollableEffect> effects, Expression<Func<TOwner, IEnumerable<RollableEffect>>> collectionSelector)
          where TOwner : BaseEntity
        {
            RollableEffect[] effectsArray = effects.ToArray();
            for (int i = 0; i < effectsArray.Length; i++)
            {
                RollableEffect effect = effectsArray[i];
                effect.OwnerId = owner.Id;
                builder.AddData(effect);
            }
        }

        public static void AddActionEffects<TOwner>(this ModelBuilder builder, TOwner owner, IEnumerable<ActionEffect> effects, Expression<Func<TOwner, IEnumerable<ActionEffect>>> collectionSelector)
            where TOwner : BaseEntity
        {
            ActionEffect[] effectsArray = effects.ToArray();
            for (int i = 0; i < effectsArray.Length; i++)
            {
                ActionEffect effect = effectsArray[i];
                builder.AddTextBlocks(effect, effect.Effects, e => e.Effects);

                effect.Effects = new TextBlock[0];
                effect.OwnerId = owner.Id;
                
                builder.AddData(effect);
            }
        }

        public static void AddTextBlocks<TOwner>(this ModelBuilder builder, TOwner owner, IEnumerable<TextBlock> textBlocks, Expression<Func<TOwner, IEnumerable<TextBlock>>> collectionSelector)
           where TOwner : BaseEntity
        {
            TextBlock[] details = textBlocks.ToArray();
            for (int i = 0; i<details.Length; i++)
            {
                TextBlock detail = details[i];
                detail.Order = i;
                detail.OwnerId = owner.Id;
                builder.AddOwnedData(collectionSelector, detail);
            }
        }

        public static void AddPrerequisites(this ModelBuilder builder, IEnumerable<Prerequisite> prerequisites, Func<BasePrerequisiteBinding> createBinding)
        {
            foreach(Prerequisite prerequisite in prerequisites)
            {
                BasePrerequisiteBinding binding = createBinding.Invoke();
                binding.Id = prerequisite.Id;

                builder.AddPrerequisite(prerequisite, binding);
            }
        }

        public static void AddPrerequisite(this ModelBuilder builder, Prerequisite prerequisite, BasePrerequisiteBinding binding)
        {
            binding.PrerequisiteId = prerequisite.Id;
            prerequisite.BindingId = binding.Id;

            builder.AddData(binding.GetType(), binding);

            switch(prerequisite)
            {
                case ChoicePrerequisite choicePrerequisite:
                    foreach (Prerequisite innerPrerequisite in choicePrerequisite.Choices)
                    {
                        builder.AddPrerequisite(innerPrerequisite, new ChoicePrerequisiteBinding { Id = innerPrerequisite.Id, ChoiceId = choicePrerequisite.Id });
                    }

                    choicePrerequisite.Choices = Array.Empty<Prerequisite>();
                    break;

                case CombinedPrerequisite combinedPrerequisite:
                    foreach(Prerequisite innerPrerequisite in combinedPrerequisite.Entries)
                    {
                        builder.AddPrerequisite(innerPrerequisite, new CombinedPrerequisiteBinding { Id = innerPrerequisite.Id, CombinationId = combinedPrerequisite.Id });
                    }
                    combinedPrerequisite.Entries = Array.Empty<Prerequisite>();
                    break;
            }
           
            builder.Entity(prerequisite.GetType()).HasData(prerequisite);
        }

        public static void AddEffects(this ModelBuilder builder, IEnumerable<Effect> effects, Func<Effect, BaseEffectBinding> createBinding)
        {
            foreach (Effect effect in effects)
            {
                BaseEffectBinding binding = createBinding.Invoke(effect);
                binding.Id = effect.Id;

                builder.AddEffect(effect, binding);
            }
        }

        public static void AddEffect(this ModelBuilder builder, Effect? effect, BaseEffectBinding binding)
        {
            if(effect == null)
            {
                return;
            }
            
            binding.Id = effect.Id;
            binding.EffectId = effect.Id;
            effect.BindingId = binding.Id;

            builder.AddData(binding.GetType(), binding);

            switch (effect)
            {
                case GainSpecificAbilityBoostEffect boost:
                    foreach (StatEffectBinding statBinding in boost.RequiredStats)
                    {
                        statBinding.EffectId = effect.Id;
                        builder.AddData(statBinding);
                    }
                    boost.RequiredStats = Array.Empty<StatEffectBinding>();
                    break;

                case ChoiceEffect choiceEffect:
                    foreach (Effect choice in choiceEffect.Entries)
                    {
                        builder.AddEffect(choice, new ChoiceEffectBinding { Id = choice.Id, ChoiceId = choiceEffect.Id });
                    }

                    choiceEffect.Entries = Array.Empty<Effect>();
                    break;

                case CombinedEffect combinedEffect:
                    foreach (Effect entry in combinedEffect.Entries)
                    {
                        builder.AddEffect(entry, new CombinedEffectBinding { Id = entry.Id, CombinedId = combinedEffect.Id });
                    }

                    combinedEffect.Entries = Array.Empty<Effect>();
                    break;
            }

            foreach (EffectPrerequisiteBinding prerequisiteEffectBinding in effect.Prerequisites)
            {
                Prerequisite prerequisite = prerequisiteEffectBinding.Prerequisite;
                prerequisiteEffectBinding.Prerequisite = null!;
                prerequisiteEffectBinding.EffectId = effect.Id;

                builder.AddPrerequisite(prerequisite, prerequisiteEffectBinding);
            }
            effect.Prerequisites = Array.Empty<EffectPrerequisiteBinding>();

            foreach(EffectIncrement increment in effect.Increments)
            {
                increment.EffectId = effect.Id;
                increment.TriggerId = increment.Trigger.Id;
                
                builder.AddData(increment.Trigger.GetType(), increment.Trigger);
                increment.Trigger = null!;

                builder.AddData(increment.GetType(), increment);
            }
            effect.Increments = Array.Empty<EffectIncrement>();

            builder.Entity(effect.GetType()).HasData(effect);
        }

        public static void AddTraits<TOwner>(this ModelBuilder builder, TOwner owner, IEnumerable<Guid> traitIds)
           where TOwner : BaseEntity
        {
            foreach (Guid traitId in traitIds)
            {
                builder.HasJoinData<TOwner, Trait>((owner.Id, traitId));
            }
        }
    }
}
