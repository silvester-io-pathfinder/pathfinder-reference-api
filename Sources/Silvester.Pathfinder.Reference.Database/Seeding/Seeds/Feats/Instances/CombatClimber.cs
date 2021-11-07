using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CombatClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("9d5b8cf1-39db-4f9a-9137-e09677277e8e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combat Climber",
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
            yield return new TextBlock { Id = Guid.Parse("c1ece74e-4f68-4f1c-a5fc-2c9dcad64f0b"), Type = TextBlockType.Text, Text = "Your techniques allow you to fight as you climb. You’re not flat-footed while (action: Climbing | Climb) and can (action: Climb) with a hand occupied. You must still use another hand and both legs to (action: Climb)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("07b021b1-d7d2-475a-bfae-28fa729851da"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0abb6aa7-3ae8-4dc4-b0f4-9a78d6d4f466"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
