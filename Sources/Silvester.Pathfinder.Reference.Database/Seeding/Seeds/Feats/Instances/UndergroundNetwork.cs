using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UndergroundNetwork : Template
    {
        public static readonly Guid ID = Guid.Parse("db04a90b-a7b8-44b7-8950-83afc7ee9243");

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
            yield return new TextBlock { Id = Guid.Parse("7ab3acc1-5c83-452a-b60b-2ae4c91a4162"), Type = TextBlockType.Text, Text = "You’re connected to groups that know what’s going on in the streets, and you can get information out of them quickly. When you use Society to (action: Gather Information) in an area where you have a network (typically a settlement where you’ve spent at least a week or spent a day of downtime to build a network faster), you can contact a member of these groups to get information directly from them. This usually takes about an hour, and it doesn’t draw as much attention as (action: Gathering Information | Gather Information) in public might. The check and information gained otherwise follow the normal rules for (action: Gather Information)." };
            yield return new TextBlock { Id = Guid.Parse("c084c0b9-9153-4031-9493-07b53717aa7b"), Type = TextBlockType.Text, Text = "In addition, if you have successfully consulted the underground network, you get a +1 circumstance bonus to the next check to (action: Recall Knowledge) you attempt about the subject you were (action: Gathering Information | Gather Information) on, or a +2 circumstance bonus if you’re using Underworld Lore for the check. The GM might change the Lore skill related to the network depending on your location or the specifics of the network you’re tapping into." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("77dc27a0-c60e-4129-b286-953c1eca0b8f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificFeat(Guid.Parse("762731ef-72bf-4c87-a65a-382e4ba23652"), Feats.Instances.Streetwise.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be9bed27-a7aa-43c8-b65e-de4bccdbf420"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
