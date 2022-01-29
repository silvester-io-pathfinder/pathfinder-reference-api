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
    public class WallJump : Template
    {
        public static readonly Guid ID = Guid.Parse("23aea7fe-7a10-4aa1-91ea-c334d1b19801");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wall Jump",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e48e1d1-3167-453c-9701-20ca1af988c3"), Type = TextBlockType.Text, Text = $"You can use your momentum from a jump to propel yourself off a wall. If you're adjacent to a wall at the end of a jump (whether performing a {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)}, or {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)}), you don't fall as long as your next action is another jump. Furthermore, since your previous jump gives you momentum, you can use {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} as a single action, but you don't get to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} as part of the activity." };
            yield return new TextBlock { Id = Guid.Parse("9b5222da-19e5-49b2-98f5-9b963f42c2e5"), Type = TextBlockType.Text, Text = $"You can use Wall Jump only once in a turn, unless you're legendary in Athletics, in which case you can use Wall Jump as many times as you can use consecutive jump actions in that turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("51d7df35-1188-4359-9bf0-b466b6c87cdb"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("368e6a99-3a7a-4a3c-985b-0cf05e6bd140"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("9dcb05e4-77bf-4ab1-a205-433c9ab5cbe7"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ea9d466-9da6-48bc-b6a4-4e4e75871a2c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
