using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FoilSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("4bf44596-dbd3-48e0-a991-f4f5e33fed0c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Foil Senses",
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
            yield return new TextBlock { Id = Guid.Parse("466c4c5f-c2b4-428a-a93c-4964c7313bb7"), Type = TextBlockType.Text, Text = "You are adept at foiling creatures’ special senses and cautious enough to safeguard against them at all times. Whenever you use the (Activity: Avoid Notice), (Action: Hide), or (Action: Sneak) actions, you are always considered to be taking precautions against special senses (see the Detecting with Other Senses sidebar on page 465)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("71d03a48-fb37-4b09-851e-c82f90c68aa5"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0ce35d4-393e-41ce-ab4e-b0b7c10bc5b8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
