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
    public class FascinatingPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("002815e8-8ded-4b2f-8a3c-efcb8e0de3a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fascinating Performance",
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
            yield return new TextBlock { Id = Guid.Parse("83a7a6aa-e082-40c9-9f0e-4adaed539c40"), Type = TextBlockType.Text, Text = $"When you {ToMarkdownLink<Models.Entities.SkillAction>("Perform", SkillActions.Instances.Perform.ID)}, compare your result to the Will DC of one observer. If you succeed, the target is fascinated by you for 1 round. If the observer is in a situation that demands immediate attention, such as combat, you must critically succeed to fascinate it and the {ToMarkdownLink<Models.Entities.SkillAction>("Perform", SkillActions.Instances.Perform.ID)} action gains the {ToMarkdownLink<Models.Entities.Trait>("incapacitation", Traits.Instances.Incapacitation.ID)} trait. You must choose which creature you're trying to fascinate before you roll your check, and the target is then temporarily immune for 1 hour. If you're an expert in Performance, you can fascinate up to four observers; if you're a master, you can fascinate up to 10 observers; and if you're legendary, you can fascinate any number of observers at the same time." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d3dc99af-0a98-4cb8-81f8-87b6825d8f39"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
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
                Id = Guid.Parse("813586ae-69a7-4dfc-88b8-791ab4b35f6f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
