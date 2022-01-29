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
    public class MeditativeWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("ff60e54e-df19-4986-ba54-97889eaacdc3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Meditative Wellspring",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7f060225-c03f-475d-91c5-08a2b60b3316"), Type = TextBlockType.Text, Text = $"When you clear your mind, your focus comes flowing back in a powerful rush. If you have spent at least 3 Focus Points since the last time you {ToMarkdownLink<Models.Entities.Activity>("Refocused", Activities.Instances.Refocus.ID)}, you recover 3 Focus Points when you {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0c7aae8c-5dab-47c2-89ac-fff760c80343"), Feats.Instances.MeditativeFocus.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("587c626a-d74d-496e-91a6-8fe20dbe4e0c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
