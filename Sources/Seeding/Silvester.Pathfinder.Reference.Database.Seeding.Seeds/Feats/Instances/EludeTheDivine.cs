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
    public class EludeTheDivine : Template
    {
        public static readonly Guid ID = Guid.Parse("24ebb040-6f93-4e27-84fc-9a5bb69f3918");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elude the Divine",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb9f992d-0811-4c0a-a34f-73fe01198fa9"), Type = TextBlockType.Text, Text = $"You are able to escape inquisitions involving divine magic, allowing you to blend in well in Mzali but also to avoid unwanted attention in other oppressive theocracies. You gain the {ToMarkdownLink<Models.Entities.Feat>("Slippery Secrets", Feats.Instances.SlipperySecrets.ID)} skill feat, and its benefits also apply against {ToMarkdownLink<Models.Entities.Trait>("divination", Traits.Instances.Divination.ID)} effects that attempt to discern your deity. When using {ToMarkdownLink<Models.Entities.Feat>("Slippery Secrets", Feats.Instances.SlipperySecrets.ID)} against a {ToMarkdownLink<Models.Entities.Trait>("divine", Traits.Instances.Divine.ID)} {ToMarkdownLink<Models.Entities.Trait>("divination", Traits.Instances.Divination.ID)}, you gain a +2 circumstance bonus, and on a critical success, the divination reveals false information appropriate to your false persona, rather than nothing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d4478e45-661e-448a-b472-550f951117d0"), Feats.Instances.BrightLionDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05501a1c-3aa8-4ab1-8e0a-5fcadf068fa4"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
