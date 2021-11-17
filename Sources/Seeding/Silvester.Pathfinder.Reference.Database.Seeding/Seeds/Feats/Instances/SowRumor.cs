using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SowRumor : Template
    {
        public static readonly Guid ID = Guid.Parse("6f44bb8e-9ba4-4092-bc86-5ec77e477a26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sow Rumor",
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
            yield return new TextBlock { Id = Guid.Parse("fd33fc80-9289-4754-9398-aa61b7b10aaf"), Type = TextBlockType.Text, Text = "~ Access: member of the Firebrands (second Rank)" };
            yield return new TextBlock { Id = Guid.Parse("34a4c403-0a9c-4f33-af2b-44f627fc0e81"), Type = TextBlockType.Text, Text = "You spread rumors, which may or may not be true, about a specific subject. If the subject of your rumor is not currently the subject of any contradictory rumors, this takes as long as it would normally take you to (action: Gather Information) (typically 2 hours), at the end of which the GM rolls a secret Deception check to see how well you spread the rumor. If your rumor matches any current rumors about the subject, it takes less time to spread the rumor, and if you are attempting to overtake a particularly popular and contradictory rumor, it takes much longer or may be impossible. The DC similarly increases or decreases depending on how plausible your rumor is." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0d6f0615-c08e-40b8-b56f-4e10d2176204"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("06472b70-15bf-4c54-9773-4e4630bee23a"),
                CriticalSuccess = "Your rumor spreads like wildfire. Anyone who succeeds at a check to (action: Gather Information) on the specific subject learns your rumor in preference to other rumors about the subject. Your rumor persists for 1 month.",
                Success = "You successfully spread the rumor. Anyone who succeeds at a check to (action: Gather Information) on the specific subject adds your rumor to the list of rumors they could learn about the subject. Your rumor persists for 1 week.",
                Failure = "Your rumor dies off, never becoming popular enough for other people to learn it via (action: Gather Information).",
                CriticalFailure = "You are unable to spread a rumor and take a -4 circumstance penalty to Deception checks to Sow Rumors about the same subject within the same region for 1 week. In addition, a rumor spreads about someone trying to spread false rumors about the subject.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("375dfd84-9fc3-492b-b253-39a2e0c12811"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
