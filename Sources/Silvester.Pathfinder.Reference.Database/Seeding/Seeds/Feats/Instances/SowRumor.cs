using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SowRumor : Template
    {
        public static readonly Guid ID = Guid.Parse("eb43b806-afd2-4e87-a623-f832657654d6");

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
            yield return new TextBlock { Id = Guid.Parse("599543a6-987b-4906-9f50-4857791fcc30"), Type = TextBlockType.Text, Text = "~ Access: member of the Firebrands (second Rank)" };
            yield return new TextBlock { Id = Guid.Parse("fea0e123-13d3-4d52-8d54-247c811ee0c1"), Type = TextBlockType.Text, Text = "You spread rumors, which may or may not be true, about a specific subject. If the subject of your rumor is not currently the subject of any contradictory rumors, this takes as long as it would normally take you to (action: Gather Information) (typically 2 hours), at the end of which the GM rolls a secret Deception check to see how well you spread the rumor. If your rumor matches any current rumors about the subject, it takes less time to spread the rumor, and if you are attempting to overtake a particularly popular and contradictory rumor, it takes much longer or may be impossible. The DC similarly increases or decreases depending on how plausible your rumor is." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c984eb91-642e-4c4f-9658-aa910dee5f14"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2d96eb00-6148-400b-a011-71a5e69f8ae4"),
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
                Id = Guid.Parse("99d992d6-7a5c-46d3-8040-2cf500731829"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
