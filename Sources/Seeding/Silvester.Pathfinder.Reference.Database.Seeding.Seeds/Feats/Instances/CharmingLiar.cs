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
    public class CharmingLiar : Template
    {
        public static readonly Guid ID = Guid.Parse("d971ace1-1754-47a9-a687-f17ba25d7604");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Charming Liar",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32c0997d-0f9b-4683-ae81-59697a59d1d8"), Type = TextBlockType.Text, Text = $"Your charm allows you to win over those you lie to. When you get a critical success using the {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)} action, the target's attitude toward you improves by one step, as though you'd succeeded at using Diplomacy to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)}. This works only once per conversation, and if you critically succeed against multiple targets using the same result, you choose one creature's attitude to improve. You must be lying to impart seemingly important information, inflate your status, or ingratiate yourself, which trivial or irrelevant lies can't achieve." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5dd5c9ef-aa4e-467c-8113-62f3a0304ec6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
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
                Id = Guid.Parse("86fa9c1b-c501-46ae-9f36-fe2fc7b54646"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
