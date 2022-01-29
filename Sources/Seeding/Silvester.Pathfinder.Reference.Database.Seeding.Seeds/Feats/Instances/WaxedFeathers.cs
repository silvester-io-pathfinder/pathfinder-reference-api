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
    public class WaxedFeathers : Template
    {
        public static readonly Guid ID = Guid.Parse("ada2bec8-6775-41cc-97fb-1972a75ecde5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Waxed Feathers",
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
            yield return new TextBlock { Id = Guid.Parse("774af703-a05f-4922-9bd2-cfa0c7e1b1da"), Type = TextBlockType.Text, Text = $"Your feathers are coated in a waxy substance that repels water. You gain a +1 circumstance bonus to saving throws against effects that have the {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)} trait. So long as you're in a dry place, you can spend one action to shake off any water that clings to your clothing and feathers to instantly become dry." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("fdbfd465-1909-4c10-9de1-2ce2bcc1711d"), Heritages.Instances.WavediverTengu.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e76e68b0-061d-44f6-b08a-1922c71a8a2d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
