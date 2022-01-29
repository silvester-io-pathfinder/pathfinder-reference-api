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
    public class Confabulator : Template
    {
        public static readonly Guid ID = Guid.Parse("294574bc-12ab-417f-8165-1053ab124d80");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Confabulator",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60c83f0b-f052-4f43-82b8-788e89bc7a2b"), Type = TextBlockType.Text, Text = $"Even when caught in falsehoods, you pile lie upon lie. Reduce the circumstance bonus a target gains for your previous attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Create a Diversion", SkillActions.Instances.CreateADiversion.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)} to it from +4 to +2. If you're a master in Deception, reduce the bonus to +1, and if you're legendary, your targets don't get these bonuses at all." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1e30412d-ea6e-42c7-a8cd-225d7a1f85e3"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7e35905-34b4-42d4-8846-b85bfe990d2d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
