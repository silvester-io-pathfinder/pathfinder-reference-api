using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RagingAthlete : Template
    {
        public static readonly Guid ID = Guid.Parse("354a3112-d1c5-46ec-8343-76e0a56357b0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raging Athlete",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32bce0cf-c20e-41e9-bde7-460cfb1b5132"), Type = TextBlockType.Text, Text = "Physical obstacles can’t hold back your fury. While you are raging, you gain a climb Speed and swim Speed equal to your land Speed and the DC of (action: High Jumps | High Jump) and (action: Long Jumps | Long Jump) decreases by 10. Your distance for a vertical (action: Leap) increases to 5 feet vertically, and your distance for a horizontal (action: Leap) increases to 15 feet if your Speed is at least 15 feet and to 20 feet if your Speed is at least 30 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("679c8d22-122b-4666-af76-597967bb1694"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f779915f-9d57-46ae-8aec-fd108826b7a9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
