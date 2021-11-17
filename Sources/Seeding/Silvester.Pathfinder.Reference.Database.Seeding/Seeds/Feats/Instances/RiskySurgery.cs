using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RiskySurgery : Template
    {
        public static readonly Guid ID = Guid.Parse("d8d247de-7be9-4a0e-860d-03431d04d340");

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
            yield return new TextBlock { Id = Guid.Parse("87095902-7cd6-4877-a2d4-3420c60008f8"), Type = TextBlockType.Text, Text = "Your surgery can bring a patient back from the brink of death, but might push them over the edge. When you (action: Treat Wounds), you can deal 1d8 slashing damage to your patient just before applying the effects of (action: Treat Wounds). If you do, you gain a +2 circumstance bonus to your Medicine check to (action: Treat Wounds), and if you roll a success, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("57cd25aa-13be-41b4-9e85-aeefd4dff89a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1116b43-62b5-4391-945c-c5885c26a332"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
