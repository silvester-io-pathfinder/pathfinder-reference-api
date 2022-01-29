using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormLock : Template
    {
        public static readonly Guid ID = Guid.Parse("73ba841c-aea3-49c9-96eb-9a425f06e2a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form Lock",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d71e263b-e72e-4c22-88bb-2fad81a89a7c"), Type = TextBlockType.Text, Text = $"Your ability to control your own ki empowers you to pressure other creatures into resuming their true forms. Attempt an Athletics check to counteract a polymorph effect currently affecting your target. If the target is somehow under the effect of multiple polymorph effects, you can choose which one to attempt to counteract, or the GM chooses randomly if the separate effects aren't obvious. The target is then temporarily immune for 1 day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8ca3f63-3f6d-45a6-92c1-b07904d9b44e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
