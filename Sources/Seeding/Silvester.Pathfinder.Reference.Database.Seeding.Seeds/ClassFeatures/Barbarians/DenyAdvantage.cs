using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class DenyAdvantage : Template
    {
        public static readonly Guid ID = Guid.Parse("e7bf3dd7-9f00-4955-b770-eddd42dc3dcf");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Deny Advantage", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("55a05be6-018d-4f6a-aec2-771a483f1d16"), Type = TextBlockType.Text, Text = "Your foes struggle to pass your defenses. You aren't flat-footed to hidden, undetected, or flanking creatures of your level or lower, or creatures of your level or lower using surprise attack. However, they can still help their allies flank." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c964a511-b2ae-403f-a480-7fb63afea1ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 84
            };
        }
    }
}
