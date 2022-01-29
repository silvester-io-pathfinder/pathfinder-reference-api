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
    public class Supertaster : Template
    {
        public static readonly Guid ID = Guid.Parse("173e3c68-dd9e-4eec-a442-0e250e5be8d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Supertaster",
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
            yield return new TextBlock { Id = Guid.Parse("963b012d-d8e7-4bcc-b29d-55481f9e6d93"), Type = TextBlockType.Text, Text = $"You have refined your palate and have a discerning sense of taste that can detect abnormalities in the flavor and texture of food and beverages. When eating food or drinking a beverage, you automatically attempt to identify the ingredients, which might alert you to the presence of alterations or additives, such as poisons. The GM rolls a secret Perception check using the poison's level to determine the DC; on a success, you learn that the food or drink was poisoned, but not the specific poison used." };
            yield return new TextBlock { Id = Guid.Parse("53237f73-2b1e-417f-aa53-1b5544761a8d"), Type = TextBlockType.Text, Text = $"If you lick or taste something while Investigating or attempting to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} to identify something, if the taste would provide relevant additional information (at the GM's discretion), you gain a +2 circumstance bonus to your check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("808504e8-4ecf-4861-8e23-87ba9743b43f"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6b32abe-b795-4b2a-8b9d-99ca3027a5d2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
