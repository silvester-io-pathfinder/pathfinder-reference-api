using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnassumingDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("5c7cdaab-3bbf-4023-851f-8ac10eb3c909");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unassuming Dedication",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf3009a4-20cc-4f8c-9271-a43c9d3688ae"), Type = TextBlockType.Text, Text = $"~ Access: Uhlam ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("404f8a49-c710-490f-abbc-ebef4307ac4a"), Type = TextBlockType.Text, Text = $"Your family instilled the values of care and patience into you from a young age. You gain a +1 circumstance bonus to checks to perform a {ToMarkdownLink<Models.Entities.Trait>("downtime", Traits.Instances.Downtime.ID)} activity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ab92a41-dc82-4a8b-975c-5f597a2f25ad"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
