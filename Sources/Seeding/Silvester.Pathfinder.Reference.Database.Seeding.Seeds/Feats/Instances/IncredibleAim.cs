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
    public class IncredibleAim : Template
    {
        public static readonly Guid ID = Guid.Parse("762e0cb6-b842-49d8-a204-5ebc57e21678");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Aim",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55cd9e0f-974c-4e64-b1a2-1e21a165521f"), Type = TextBlockType.Text, Text = $"By spending a moment to focus, you can ensure your attack strikes true. Make a ranged weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. On this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, you gain a +2 circumstance bonus to the attack roll and ignore the target's concealed condition." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fac49660-a0ab-4cc0-91c9-2add5e3580e2"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("5781326c-35b3-440e-99a9-aa17fdbabaf3"), Traits.Instances.Fighter.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46242884-7568-479f-a357-e22c8c08a55e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
