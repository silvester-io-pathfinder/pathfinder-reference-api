using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class PerfectedForm : Template
    {
        public static readonly Guid ID = Guid.Parse("9c0499d8-0bbe-4e6b-bef5-bfba4b3376b7");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Perfected Form", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("47e01e48-8e99-4bd4-94d5-17722ac41d4c"), Type = TextBlockType.Text, Text = "You have purged incompetence from your techniques. On your first Strike of your turn, if you roll lower than 10, you can treat the attack roll as a 10. This is a fortune effect." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aadbae60-2987-477c-9534-f525af68efbb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 158
            };
        }
    }
}
