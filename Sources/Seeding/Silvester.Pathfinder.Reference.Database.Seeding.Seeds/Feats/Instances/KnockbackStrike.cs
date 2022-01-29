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
    public class KnockbackStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("78f6ed6e-05cb-4c75-b81b-0cc5b0cefa26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knockback Strike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10569106-cd1f-46bd-af9b-a3ef5deab800"), Type = TextBlockType.Text, Text = $"You focus your strength into a blow powerful enough to push an enemy away from you. Make an unarmed {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("e45ae3cf-62c6-47ae-8aef-d96f2f6dac0b"), Type = TextBlockType.Text, Text = $"If you hit, attempt an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} the target. This attack uses the same multiple attack penalty as your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, and doesn't count toward your multiple attack penalty." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("450c5c46-0592-4d3a-b048-358c71b46f00"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
