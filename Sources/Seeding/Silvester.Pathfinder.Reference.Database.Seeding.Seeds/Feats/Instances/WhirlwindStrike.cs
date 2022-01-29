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
    public class WhirlwindStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("50589239-e4c8-482a-bb23-639b557aecfb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirlwind Strike",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9622bdb2-2d71-49ae-b52e-c65cc8ee28c5"), Type = TextBlockType.Text, Text = $"You attack all nearby adversaries. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against each enemy within your melee reach. Each attack counts toward your multiple attack penalty, but do not increase your penalty until you have made all your attacks." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Open.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("797616c5-9590-4fd7-aa44-83d950846278"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
