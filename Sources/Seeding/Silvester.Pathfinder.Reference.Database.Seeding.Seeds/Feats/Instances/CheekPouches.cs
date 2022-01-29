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
    public class CheekPouches : Template
    {
        public static readonly Guid ID = Guid.Parse("9a444a87-15ec-430b-a0d3-d27ce571f938");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cheek Pouches",
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
            yield return new TextBlock { Id = Guid.Parse("d8211d88-c892-4ef8-b1e9-0f66502ab5b1"), Type = TextBlockType.Text, Text = $"Your cheeks are stretchy, and you can store up to four items of light Bulk or less in these cheek pouches. None of these items can have a dimension longer than 1 foot. As long as you have at least one item in your cheek pouches, your speech is noticeably difficult to understand. Placing an item in your cheek pouch or retrieving one is an {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action. You can empty your mouth with a single action, causing everything you had stored in your cheek pouches to fall to the ground in your square." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a5e9cd59-8e5a-4238-a053-eae8ee88b420"), Traits.Instances.Ratfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c02211c-02e4-4da0-94d1-6e6d9757d562"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
