using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrifiedRetreat : Template
    {
        public static readonly Guid ID = Guid.Parse("c196d0bf-aeea-48c2-a786-42519dd4c305");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrified Retreat",
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
            yield return new TextBlock { Id = Guid.Parse("3c46f31f-f847-4119-b7ad-0962a2fbcb40"), Type = TextBlockType.Text, Text = "When you critically succeed at the (action: Demoralize) action, if the target’s level is lower than yours, the target is fleeing for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("22fd84d7-4cb2-4594-9f81-7e19a1da4161"), Proficiencies.Instances.Master.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0df344e-829d-4a50-9b34-b12490153cd4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
