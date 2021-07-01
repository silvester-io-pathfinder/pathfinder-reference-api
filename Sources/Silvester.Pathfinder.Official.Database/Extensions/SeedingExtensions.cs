using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Extensions
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
