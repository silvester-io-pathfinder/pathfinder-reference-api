using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds
{

    public static class SeedBuilderExtensions
    {
        public static ISeedBuilder AddTable<TOwner>(this ISeedBuilder self, TOwner owner, Table? table)
               where TOwner : BaseEntity
        {
            if (table == null)
            {
                return self;
            }

            table.OwnerId = owner.Id;

            for (int iColumn = 0; iColumn < table.Columns.Count(); iColumn++)
            {
                Column column = table.Columns.ElementAt(iColumn);
                column.Order = iColumn;
                column.TableId = table.Id;
                self.AddData(column);
            }

            for (int iRow = 0; iRow < table.Rows.Count(); iRow++)
            {
                Row row = table.Rows.ElementAt(iRow);

                for (int iCell = 0; iCell < row.Cells.Count(); iCell++)
                {
                    Cell cell = row.Cells.ElementAt(iCell);
                    cell.RowId = row.Id;
                    cell.Order = iCell;
                    self.AddData(cell);
                }

                row.TableId = table.Id;
                row.Order = iRow;
                row.Cells = new List<Cell>();

                self.AddData(row);
            }

            table.Rows = new List<Row>();
            table.Columns = new List<Column>();

            self.AddData(table);
            return self;
        }

        public static ISeedBuilder AddTraits<TOwner>(this ISeedBuilder self, TOwner owner, IEnumerable<Guid> traitIds)
           where TOwner : BaseEntity
        {
            self.AddJoinData<TOwner, Trait>(owner, traitIds);
            return self;
        }

        public static ISeedBuilder AddRollableEffect<TOwner>(this ISeedBuilder self, TOwner owner, RollableEffect? effect)
            where TOwner : BaseEntity
        {
            if (effect != null)
            {
                effect.OwnerId = owner.Id;
                self.AddData(effect);
            }

            return self;
        }

        public static ISeedBuilder AddTextBlocks<TOwner>(this ISeedBuilder self, TOwner owner, IEnumerable<TextBlock> textBlocks, Expression<Func<TOwner, IEnumerable<TextBlock>>> collectionSelector)
            where TOwner : BaseEntity
        {
            TextBlock[] asArray = textBlocks.ToArray();
            for (int i = 0; i < asArray.Length; i++)
            {
                TextBlock textBlock = asArray[i];
                textBlock.Order = i;
                textBlock.OwnerId = owner.Id;
            }

            collectionSelector.SetProperty(owner, asArray);
            return self;
        }

        public static ISeedBuilder AddSourcePage<TOwner>(this ISeedBuilder self, TOwner owner, SourcePage? sourcePage, Expression<Func<TOwner, Guid?>> keySelector)
            where TOwner : BaseEntity
        {
            if (sourcePage != null)
            {
                sourcePage.OwnerId = owner.Id;
                keySelector.SetProperty(owner, sourcePage.Id);
                self.AddData(sourcePage);
            }

            return self;
        }

        public static ISeedBuilder AddEffect(this ISeedBuilder self, BaseEffect? effect)
        {
            if (effect == null)
            {
                return self;
            }

            switch (effect)
            {
                case BooleanEffect booleanEffect:
                    foreach (BooleanEffectBinding binding in booleanEffect.Entries)
                    {
                        self.AddEffect(binding.Effect);
                        binding.Effect = null!;
                        self.AddData(binding.GetType(), binding);
                    }

                    booleanEffect.Entries = new List<BooleanEffectBinding>();
                    break;

                case ModifyFeatEffectsEffect modifyFeatEffect:
                    self.AddEffect(modifyFeatEffect.ModificationEffect);
                    modifyFeatEffect.ModificationEffect = null!;

                    break;

                case ChoiceEffect choiceEffect:
                    foreach (ChoiceEffectBinding binding in choiceEffect.Entries)
                    {
                        self.AddEffect(binding.Effect);
                        binding.Effect = null!;
                        self.AddData(binding.GetType(), binding);
                    }
                    self.AddData(choiceEffect.Choice.GetType(), choiceEffect.Choice);
                    choiceEffect.ChoiceId = choiceEffect.Choice.Id;
                    choiceEffect.Choice = null!;
                    choiceEffect.Entries = new List<ChoiceEffectBinding>();
                    break;
            }

            if (effect.Prerequisite != null)
            {
                effect.PrerequisiteId = effect.Prerequisite.Id;
                self.AddPrerequisite(effect.Prerequisite);
            }
            effect.Prerequisite = null;

            foreach (EffectIncrement increment in effect.Increments)
            {
                increment.EffectId = effect.Id;
                increment.TriggerId = increment.Trigger.Id;

                self.AddData(increment.Trigger.GetType(), increment.Trigger);
                increment.Trigger = null!;

                self.AddData(increment.GetType(), increment);
            }
            effect.Increments = new List<EffectIncrement>();

            self.AddData(effect.GetType(), effect);
            return self;
        }

        public static ISeedBuilder AddPrerequisite(this ISeedBuilder self, BasePrerequisite? prerequisite)
        {
            if (prerequisite == null)
            {
                return self;
            }

            switch (prerequisite)
            {
                case BooleanPrerequisite booleanPrerequisite:
                    foreach (BooleanPrerequisiteBinding binding in booleanPrerequisite.Entries)
                    {
                        self.AddPrerequisite(binding.Prerequisite);
                        binding.Prerequisite = null!;
                        self.AddData(binding.GetType(), binding);
                    }

                    booleanPrerequisite.Entries = new List<BooleanPrerequisiteBinding>();
                    break;
            }

            self.AddData(prerequisite.GetType(), prerequisite);
            return self;
        }

        public static ISeedBuilder AddEffect<TOwner>(this ISeedBuilder self, TOwner owner, Action<BooleanEffectBuilder> buildAction, Expression<Func<TOwner, Guid?>> keySelector, Guid? overrideId = null)
            where TOwner : BaseEntity
        {
            BooleanEffectBuilder builder = BooleanEffectBuilder.CreateAnd(overrideId.HasValue ? overrideId.Value : owner.Id, buildAction);
            BooleanEffect effect = builder.Build();

            keySelector.SetProperty(owner, effect.Id);

            return self.AddEffect(effect);
        }

        public static ISeedBuilder AddPrerequisite<TOwner>(this ISeedBuilder self, TOwner owner, Action<BooleanPrerequisiteBuilder> buildAction)
            where TOwner : BaseEntity
        {
            BooleanPrerequisiteBuilder builder = BooleanPrerequisiteBuilder.CreateAnd(owner.Id, buildAction);
            BooleanPrerequisite prerequisite = builder.Build();

            return self.AddPrerequisite(prerequisite);
        }
    }
}
