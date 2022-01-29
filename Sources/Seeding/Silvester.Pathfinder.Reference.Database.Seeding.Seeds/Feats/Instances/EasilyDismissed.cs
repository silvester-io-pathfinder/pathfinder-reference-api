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
    public class EasilyDismissed : Template
    {
        public static readonly Guid ID = Guid.Parse("9f2c4ae9-db91-4507-beb3-76446dd3e6a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Easily Dismissed",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("422a805c-1daf-4005-b441-76a49c009368"), Type = TextBlockType.Text, Text = $"~ Access: Chelaxian nationality" };
            yield return new TextBlock { Id = Guid.Parse("94fc5978-b5d1-4051-9e6d-77af295a241f"), Type = TextBlockType.Text, Text = $"You are practiced at blending into the background of the streets and halls of larger folk to ensure that you are overlooked. When you are in a crowd or well trafficked urban area, you can attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)}, even when observed. On a success, you aren't hidden or undetected, but other creatures simply don't take particular notice of you, even though they can see you. You can't use this ability on observers who have already seen you perform obtrusive or notable actions. If you perform any action other than to {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} or otherwise take particularly salient actions (GM's discretion), observers notice you right away." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f3c2613a-2f4d-4849-809d-b8852abe5207"), Traits.Instances.Halfling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d779e1c-c6b5-427c-a2ab-fe3c27624dd9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
