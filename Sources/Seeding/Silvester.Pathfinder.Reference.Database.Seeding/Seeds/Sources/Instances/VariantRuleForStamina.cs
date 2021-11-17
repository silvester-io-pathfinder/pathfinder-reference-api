using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class VariantRuleForStamina : Template
    {
        public static readonly Guid ID = Guid.Parse("a631f251-5d59-431b-91e9-1b4d54e44134");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Variant Rule for Stamina"
            };
        }
    }
}
