using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PartyCrasher : Template
    {
        public static readonly Guid ID = Guid.Parse("f7b89159-bc2a-4a1a-a32a-6cd4f9c7ec58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Party Crasher",
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
            yield return new TextBlock { Id = Guid.Parse("1f3dc13d-c3d0-4450-baff-28c054dd95b7"), Type = TextBlockType.Text, Text = "You attend all the fashionable society parties, no matter how exclusive they might be. Any time you encounter a social event you would ordinarily be denied access to, such as a coronation, royal gala, or other society function, you can spend 1d4 hours to secure entry without the need for a skill check. You find invitations, invitees looking for fashionable dates, temporary jobs with the caterers, event staff willing to look the other way, or some other mode of access for yourself and your allies. This ability doesn’t apply to secret events or other small private gatherings with no staff, dates, or outsiders involved." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b95898bd-8dcc-4cb4-a349-069cd2524ffe"), Feats.Instances.DandyDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("f84a773b-76c5-400a-b621-5ccc19f5fd27"), Proficiencies.Instances.Master.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b53d131-1eb6-4d18-9178-0afcfa6f0f1a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
