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
    public class Seasoned : Template
    {
        public static readonly Guid ID = Guid.Parse("8553d6d7-7561-496c-8913-6943fde72652");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seasoned",
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
            yield return new TextBlock { Id = Guid.Parse("c9edd55d-fd39-48a1-b0c4-a41d218e40d5"), Type = TextBlockType.Text, Text = $"You've mastered the preparation of many types of food and drink. You gain a +1 circumstance bonus to checks to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} food and drink, including potions. If you are a master in one of the prerequisite skills, this bonus increases to +2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b12f5294-5569-4b0a-9f00-40e37d709512"), or => 
            {
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("fd3fb002-403a-4304-8f47-15cd69e70693"), Proficiencies.Instances.Trained.ID, Lores.Instances.Alcohol.ID);
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("da591f4f-123f-4250-9fa5-c3f5842e083f"), Proficiencies.Instances.Trained.ID, Lores.Instances.Cooking.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("d0fd1045-0dcf-40a9-b494-4edf8f0565c3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6c7362a-8672-4a5a-b0fe-36bdbff3af1e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
