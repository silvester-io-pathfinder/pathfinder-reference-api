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
    public class CityScavenger : Template
    {
        public static readonly Guid ID = Guid.Parse("3fb8eea3-fdf9-4fc0-9df6-811387a67e17");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "City Scavenger",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the irongut goblin heritage, increase the bonuses to +2.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c68836fb-7545-4415-9489-8292ccf6e97d"), Type = TextBlockType.Text, Text = $"You know that the greatest treasures often look like refuse, and you scoff at those who throw away perfectly good scraps. You gain a +1 circumstance bonus to checks to {ToMarkdownLink<Models.Entities.SkillAction>("Subsist", SkillActions.Instances.Subsist.ID)}, and you can use Society or Survival when you {ToMarkdownLink<Models.Entities.SkillAction>("Subsist", SkillActions.Instances.Subsist.ID)} in a settlement." };
            yield return new TextBlock { Id = Guid.Parse("16a8bcc7-8ccc-4e8f-bca9-36aa416a0578"), Type = TextBlockType.Text, Text = $"When you {ToMarkdownLink<Models.Entities.SkillAction>("Subsist", SkillActions.Instances.Subsist.ID)} in a city, you also gather valuable junk that silly longshanks threw away. You can {ToMarkdownLink<Models.Entities.SkillAction>("Earn Income", SkillActions.Instances.EarnIncome.ID)} using Society or Survival in the same time as you {ToMarkdownLink<Models.Entities.SkillAction>("Subsist", SkillActions.Instances.Subsist.ID)}, without spending any additional days of downtime. You also gain a +1 circumstance bonus to this check." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("79cb4c1f-ccba-43e6-a338-2c48db5fa6b3"), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dba90d62-e961-4ecd-9fdd-65b01721822e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
