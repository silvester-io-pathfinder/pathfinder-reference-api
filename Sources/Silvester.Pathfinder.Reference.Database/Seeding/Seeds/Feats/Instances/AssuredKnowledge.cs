using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AssuredKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("2a415052-d15f-420a-90a3-39f49a242dd5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assured Knowledge",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34ebf72f-fd73-4ae0-8332-92f10a353ce1"), Type = TextBlockType.Text, Text = "You can procure information with confidence. Whenever you (action: Recall Knowledge) using any skill (including Loremaster Lore), you can forgo rolling your check to instead receive a result of 10 + your proficiency bonus (don’t apply any other bonuses, penalties, or modifiers). As long as you are an expert in a skill, you meet the prerequisites for the (feat: Automatic Knowledge) skill feat in that skill, even if you don’t have (feat: Assurance) in that skill." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("390acb08-c326-4423-8ee9-703369a4cc98"), Feats.Instances.LoremasteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4250ddc1-3b46-491b-8122-5607c4d0e04c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
