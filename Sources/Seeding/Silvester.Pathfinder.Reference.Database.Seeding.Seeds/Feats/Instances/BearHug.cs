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
    public class BearHug : Template
    {
        public static readonly Guid ID = Guid.Parse("f216bb6f-6b07-4a15-b9ba-d2aeae514206");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bear Hug",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93f701fc-2e85-483d-8983-edc5a92f5921"), Type = TextBlockType.Text, Text = $"The bear makes another claw {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the same target. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, the target is also grabbed, as if the bear had successfully {ToMarkdownLink<Models.Entities.SkillAction>("Grappled", SkillActions.Instances.Grapple.ID)} the target." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55e4f358-d63a-4ce1-af74-6b017b485daa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
