using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BountyHunterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("0219fe23-5284-45a2-af22-25bf011def80");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bounty Hunter Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the bounty hunter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("081e1302-87af-4b8b-841d-f25407eb830a"), Type = TextBlockType.Text, Text = "When focused on finding your quarry, you’re relentless. You gain the (feat: Hunt Prey) action. You can use (feat: Hunt Prey) to designate only a creature that you’ve seen, heard about, or learned about through some other means, such as a bounty board or wanted poster. In addition to the other benefits of (feat: Hunt Prey), you gain a +2 circumstance bonus to checks to (action: Gather Information) regarding your prey." };
            yield return new TextBlock { Id = Guid.Parse("095faf0c-b061-4ada-9bd3-0809199a7887"), Type = TextBlockType.Text, Text = "If you already have (feat: Hunt Prey), you become an expert in Survival and gain the circumstance bonus to (action: Gather Information) about your prey; you can still designate a creature you’re tracking during exploration, in addition to the conditions above." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("284d9a19-3bd6-40f7-8c0e-b83a492d569e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cae1d5c0-2c58-4d6c-8b86-eeac58ea7be1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
