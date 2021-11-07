using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Confabulator : Template
    {
        public static readonly Guid ID = Guid.Parse("5c250102-85b3-4c3a-a991-8d9804ac062e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Confabulator",
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
            yield return new TextBlock { Id = Guid.Parse("837c5856-a0ba-44cd-ace7-334f4cdd8003"), Type = TextBlockType.Text, Text = "Even when caught in falsehoods, you pile lie upon lie. Reduce the circumstance bonus a target gains for your previous attempts to (action: Create a Diversion) or (action: Lie) to it from +4 to +2. If you’re a master in Deception, reduce the bonus to +1, and if you’re legendary, your targets don’t get these bonuses at all." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3af2c5e6-59de-405d-84c6-b935cfe1b3f3"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b8dc56e-1cf8-476d-bd4f-e428a7c7b8d6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
