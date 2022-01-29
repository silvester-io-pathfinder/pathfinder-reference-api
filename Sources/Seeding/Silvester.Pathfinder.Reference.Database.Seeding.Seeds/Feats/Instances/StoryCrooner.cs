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
    public class StoryCrooner : Template
    {
        public static readonly Guid ID = Guid.Parse("dc6a42d0-a2fe-4a71-854d-1714b963c292");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Story Crooner",
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
            yield return new TextBlock { Id = Guid.Parse("400c3a9b-8424-44ca-9b23-b31a373be58a"), Type = TextBlockType.Text, Text = $"You're a talented story weaver and use your voice effectively. You are trained in Performance. If you would automatically become trained in Performance, you instead become trained in a skill of your choice. You also gain the {ToMarkdownLink<Models.Entities.Feat>("Impressive Performance", Feats.Instances.ImpressivePerformance.ID)} skill feat and gain a +1 circumstance bonus when {ToMarkdownLink<Models.Entities.SkillAction>("Performing", SkillActions.Instances.Perform.ID)} for an audience of strix." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("26426d18-b9a2-4f4a-80a8-4344837eda76"), Traits.Instances.Strix.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cc7f1de-2c99-498a-afca-b7396b5d1ca3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
