using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickJump : Template
    {
        public static readonly Guid ID = Guid.Parse("85d912bb-999a-4a4d-a43e-c2168df2faf8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Jump",
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
            yield return new TextBlock { Id = Guid.Parse("4080866e-9d4b-48c5-8b25-d24988c9c74a"), Type = TextBlockType.Text, Text = "You can use (action: High Jump) and (action: Long Jump) as a single action instead of 2 actions. If you do, you don’t perform the initial (action: Stride) (nor do you fail if you don’t (action: Stride) 10 feet)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("de4dd797-200e-44b0-8b9d-e2ea28768bbe"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad705f98-a819-4a43-9119-c27047735c22"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
