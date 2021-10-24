using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class MajorCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Major Curse", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've learned to better balance the conflicting powers wreaking havoc on your body. Immediately after completing the casting of a revelation spell while you are affected by your moderate curse, your curse progresses to its major effect, rather than overwhelming you. This effect lasts until you Refocus, which reduces your curse to its minor effect. If you cast a revelation spell while under the effects of your major curse, you are overwhelmed by your curse." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "In addition, increase the number of Focus Points in your focus pool from 2 to 3. If you spend at least 2 Focus Points before you again Refocus, you recover 2 Focus Points when you Refocus instead of 1." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add Moderate Curse effects.
            builder.GainFocusPoolPoint(Guid.Parse(""));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 71
            };
        }
    }
}
