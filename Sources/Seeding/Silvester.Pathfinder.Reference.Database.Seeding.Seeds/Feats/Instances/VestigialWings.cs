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
    public class VestigialWings : Template
    {
        public static readonly Guid ID = Guid.Parse("d2ccb05a-ab28-4c01-9dbd-8744746d5503");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vestigial Wings",
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
            yield return new TextBlock { Id = Guid.Parse("8a50eb00-b374-4ae9-92b4-ad1e671f3ca2"), Type = TextBlockType.Text, Text = $"You possess small, weak wings that aid in balance. You gain the {ToMarkdownLink<Models.Entities.Feat>("Steady Balance", Feats.Instances.SteadyBalance.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Cat Fall", Feats.Instances.CatFall.ID)} skill feats as bonus feats, even if you aren't trained in Acrobatics." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("601f85cf-e016-4089-bc5c-89f3ae922fab"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
