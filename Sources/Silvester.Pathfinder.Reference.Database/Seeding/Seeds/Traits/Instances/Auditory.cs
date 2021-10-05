using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Auditory : Template
    {
        public static readonly Guid ID = Guid.Parse("01b25e97-5ae2-41e9-9165-338ef32f4df1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Auditory",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea6c5042-e28f-4e60-9055-c55dd26bf47f"), Type = TextBlockType.Text, Text = "Auditory actions and effects rely on sound. An action with the auditory trait can be successfully performed only if the creature using the action can speak or otherwise produce the required sounds. A spell or effect with the auditory trait has its effect only if the target can hear it. This applies only to sound-based parts of the effect, as determined by the GM. This is different from a sonic effect, which still affects targets who can't hear it (such as deaf targets) as long as the effect itself makes sound." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("006ac1ae-982f-4424-914f-bda16dcec279"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
