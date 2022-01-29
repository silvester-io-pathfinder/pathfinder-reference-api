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
    public class FiendishWings : Template
    {
        public static readonly Guid ID = Guid.Parse("246b529a-22e7-4fc7-b750-4dfbde88a68d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendish Wings",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ce56daf-1d7f-4ae9-b838-08ff1a77b303"), Type = TextBlockType.Text, Text = $"You can strain to call forth bat-like or otherwise fiendish wings from your back, similar in appearance to those of your fiendish ancestors. Once manifested, these wings remain for 10 minutes. You gain a fly Speed equal to your land Speed while you've manifested your wings." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Tiefling.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11de22a6-c11e-45e3-9c04-e793254bb21a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
