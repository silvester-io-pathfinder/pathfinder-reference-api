using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.EffectIncrements
{
    public class EffectIncrementsBuilder
    {
        private IList<EffectIncrement> Increments { get; }

        public EffectIncrementsBuilder()
        {
            Increments = new List<EffectIncrement>();
        }

        public EffectIncrementsBuilder Add(EffectIncrement increment)
        {
            Increments.Add(increment);
            return this;
        }

        public ICollection<EffectIncrement> Build()
        {
            return Increments;
        }
    }
}
