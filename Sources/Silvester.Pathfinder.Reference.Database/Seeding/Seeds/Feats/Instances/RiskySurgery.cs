using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RiskySurgery : Template
    {
        public static readonly Guid ID = Guid.Parse("90c50cea-812e-40b1-a494-592a3220829e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Risky Surgery",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23423849-8c17-4135-bbb9-f42cdc3f19fd"), Type = TextBlockType.Text, Text = "Your surgery can bring a patient back from the brink of death, but might push them over the edge. When you (action: Treat Wounds), you can deal 1d8 slashing damage to your patient just before applying the effects of (action: Treat Wounds). If you do, you gain a +2 circumstance bonus to your Medicine check to (action: Treat Wounds), and if you roll a success, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("44d610ad-b22c-4b2b-805f-d9f5c718c550"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90b6a523-1dc2-4f12-9758-0f221def5f63"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
