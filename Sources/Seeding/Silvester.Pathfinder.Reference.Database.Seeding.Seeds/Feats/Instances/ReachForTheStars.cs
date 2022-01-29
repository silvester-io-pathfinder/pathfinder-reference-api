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
    public class ReachForTheStars : Template
    {
        public static readonly Guid ID = Guid.Parse("19967f9a-e74c-4cfa-9727-ea1b02637969");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reach for the Stars",
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
            yield return new TextBlock { Id = Guid.Parse("ac98b624-4ebd-4a86-87d1-9eb146c78508"), Type = TextBlockType.Text, Text = $"The sky's the limit, as long as you've got enough black powder. When you use {ToMarkdownLink<Models.Entities.Feat>("Black Powder Boost", Feats.Instances.BlackPowderBoost.ID)}, you can expend additional black powder or ammunition to boost yourself farther. For each dose of black powder or piece of firearm ammunition you spend in addition to your shot, you add another 10 feet to the height or distance of your Leap, to a maximum of 5 boosts (a +50-foot status bonus). You must be wearing a dose of black powder or piece of ammunition, or have it in hand, to detonate it for a boost." };
            yield return new TextBlock { Id = Guid.Parse("f471cc42-47c0-4c64-9194-3008e7d87389"), Type = TextBlockType.Text, Text = $"You can choose at which points in your {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} you detonate each boost, allowing you to change direction each time. You must then move in a straight line until you boost again or end your {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("322b9d4e-daa8-4176-9d94-1a9caac67e5d"), Feats.Instances.BlackPowderBoost.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a98a606-39e1-4d93-bc7b-7fc969cc462a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
