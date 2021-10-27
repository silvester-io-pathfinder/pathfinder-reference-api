using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class ContinuousFlair : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Continuous Flair", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While not equal to the heights of your panache in combat, you have a dramatic flair about you in any situation. Whenever you succeed at a check during exploration that would have granted you panache in combat, you gain a +1 circumstance bonus to further checks for actions that would grant you panache in combat. This benefit ends when the exploration changes to a different scene (as determined by the GM) or shifts to an encounter or downtime." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 87
            };
        }
    }
}
