using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutomaticKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("d8280ff5-85a4-4c8b-a47b-994a56e3d504");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automatic Knowledge",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times, choosing a different skill each time. You can use Automatic Knowledge with any skills you have chosen, but you can still use Automatic Knowledge only once per round.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("182c0bab-9e13-4ccf-8a35-eca9bf5189ec"), Type = TextBlockType.Text, Text = "You know basic facts off the top of your head. When you select this feat, choose a skill you’re an expert in that has the (action: Recall Knowledge) action and for which you have the (feat: Assurance) feat. You can use the (action: Recall Knowledge) action with that skill as a free action once per round. If you do, you must use (feat: Assurance) on the skill check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("82bf9e6c-1398-410a-a601-4805c547cb7f"), Proficiencies.Instances.Expert.ID, requiresAssurance: True);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc4f7529-c148-4e35-9833-334abf803538"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
