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
    public class QuakingStomp : Template
    {
        public static readonly Guid ID = Guid.Parse("b429662f-5809-43a0-9870-00f6d321073e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quaking Stomp",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b818199d-a547-4a74-b6fb-8e379cf6b0d1"), Type = TextBlockType.Text, Text = $"You stomp the ground with such force that it creates a minor earthquake, with the effects of the {ToMarkdownLink<Models.Entities.Spell>("earthquake", Spells.Instances.Earthquake.ID)} spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ba3058a2-b84d-431a-ba3f-8b09998733ae"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("042360a0-b4b1-4e10-8aab-a4181a281d91"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("b9a42233-f019-45d3-9f4d-73a57a69e23e"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99999e3c-185d-4749-803b-f51bd53abcc8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
