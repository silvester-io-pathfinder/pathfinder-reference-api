using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgileManeuvers : Template
    {
        public static readonly Guid ID = Guid.Parse("92092051-d9ed-4d77-9a0e-48f4184c68a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Agile Maneuvers",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("adbe5616-8e37-4b66-8c07-97541c6cec59"), Type = TextBlockType.Text, Text = "Your easily maneuver against your foes. Your (action: Grapple), (action: Shove), and (action: Trip) actions have a lower multiple attack penalty: -4 instead of -5 if they’re the second attack on your turn, or -8 instead of -10 if they’re the third or subsequent attack on your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cd50eb39-7860-46b2-bde6-76d3f011ba65"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bc73490-07c1-4bee-8553-35e196ab4b2b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
