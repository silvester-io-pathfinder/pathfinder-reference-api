using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuietAllies : Template
    {
        public static readonly Guid ID = Guid.Parse("840c8d64-aa5e-4f05-9ddc-9eb9e3671dd1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quiet Allies",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa54d9d3-cc1f-4b7b-9e08-1fde1c937de1"), Type = TextBlockType.Text, Text = "You’re skilled at moving with a group. When you are (Activity: Avoiding Notice | Avoid Notice) and your allies (Activity: Follow the Expert), you and those allies can roll a single Stealth check, using the lowest modifier, instead of rolling separately. This doesn’t apply for initiative rolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0c73a489-a0b3-40bf-9a82-492b0522fb81"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("442786fd-4bdc-44c5-970a-6b8dcf953b45"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
