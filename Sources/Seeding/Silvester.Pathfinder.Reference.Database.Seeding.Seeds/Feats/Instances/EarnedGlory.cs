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
    public class EarnedGlory : Template
    {
        public static readonly Guid ID = Guid.Parse("acc89e8d-5da7-482e-a340-af35c48021f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Earned Glory",
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
            yield return new TextBlock { Id = Guid.Parse("f9086c5c-695c-4835-98a1-9708317c7110"), Type = TextBlockType.Text, Text = $"Elves are often skeptical of their half-elven kin, and you are experienced at telling stories of your accomplishments to gain their respect. You are trained in Performance. If you would automatically become trained in Performance (from your background or class, for example), you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("7af80172-c406-4815-b099-a4eb6ef1e31c"), Type = TextBlockType.Text, Text = $"You gain the {ToMarkdownLink<Models.Entities.Feat>("Impressive Performance", Feats.Instances.ImpressivePerformance.ID)} feat. When you attempt a Performance check to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} on an elf, if you roll a critical failure, you get a failure instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("819eae57-43dd-48c0-aa68-458b58218d67"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
