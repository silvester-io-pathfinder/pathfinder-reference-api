using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrutalBully : Template
    {
        public static readonly Guid ID = Guid.Parse("4574cbc8-a139-47ed-9986-218448635a73");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brutal Bully",
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
            yield return new TextBlock { Id = Guid.Parse("4ccccb2a-ae76-4bcc-a031-dd479419fc3f"), Type = TextBlockType.Text, Text = "You push your foes around and leave bruises. While raging, when you successfully (Action: Disarm), (Action: Grapple), (Action: Shove), or (Action: Trip) a foe, you deal that foe bludgeoning damage equal to your Strength modifier; add this to the damage from a critical success to (Action: Trip)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d962c6bd-d4b3-478b-a0c7-4f15d314a6e5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32e84fcf-3ec9-46c5-b31b-e22fe0d9946e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
