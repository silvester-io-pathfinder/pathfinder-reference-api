using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UndergroundNetwork : Template
    {
        public static readonly Guid ID = Guid.Parse("b100f43a-0933-4741-98aa-86df754f2ab0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Underground Network",
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
            yield return new TextBlock { Id = Guid.Parse("699fb8d2-25d0-4a42-813f-5085fea81777"), Type = TextBlockType.Text, Text = "You’re connected to groups that know what’s going on in the streets, and you can get information out of them quickly. When you use Society to (action: Gather Information) in an area where you have a network (typically a settlement where you’ve spent at least a week or spent a day of downtime to build a network faster), you can contact a member of these groups to get information directly from them. This usually takes about an hour, and it doesn’t draw as much attention as (action: Gathering Information | Gather Information) in public might. The check and information gained otherwise follow the normal rules for (action: Gather Information)." };
            yield return new TextBlock { Id = Guid.Parse("ec3e93dd-d0f0-45da-bb0c-2b31e17dce71"), Type = TextBlockType.Text, Text = "In addition, if you have successfully consulted the underground network, you get a +1 circumstance bonus to the next check to (action: Recall Knowledge) you attempt about the subject you were (action: Gathering Information | Gather Information) on, or a +2 circumstance bonus if you’re using Underworld Lore for the check. The GM might change the Lore skill related to the network depending on your location or the specifics of the network you’re tapping into." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("80753dcd-2c45-4149-9427-99e49111d931"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificFeat(Guid.Parse("0b2c6eb0-0a18-4d10-8060-58753ee8cf8e"), Feats.Instances.Streetwise.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64f5613f-2b72-4da4-af05-1e4c67db36a1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
