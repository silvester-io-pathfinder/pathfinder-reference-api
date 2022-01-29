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
    public class LoyalWarhorse : Template
    {
        public static readonly Guid ID = Guid.Parse("c7b70fb3-577f-4647-914a-4c92f0217acc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Loyal Warhorse",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37a9b609-9cc1-4745-82a3-b79f55e65c26"), Type = TextBlockType.Text, Text = $"You and your mount have grown closer, and your loyalty to each other is unbreakable. The mount you gained through the divine ally class feature is now a mature animal companion (page 214). In addition, your mount never attacks you, even if it is magically compelled to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("6fb3cd53-8c65-4c07-8587-9a92e4531d4d"), DivineAllies.Instances.Steed.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbb21096-4563-4848-a979-dc99cd2ccc51"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
