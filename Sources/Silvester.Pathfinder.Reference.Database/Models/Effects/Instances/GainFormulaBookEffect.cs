using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainFormulaBookEffect : BaseEffect
    {
        public int FormulaAmount { get; set; }
        public int AddFormulasPerLevel { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainFormulaBook(this BooleanEffectBuilder builder, Guid id, int formulaAmount, int addFormulasPerLevel)
        {
            return builder.Add(new GainFormulaBookEffect { Id = id, FormulaAmount = formulaAmount, AddFormulasPerLevel = addFormulasPerLevel });
        }
    }
}
