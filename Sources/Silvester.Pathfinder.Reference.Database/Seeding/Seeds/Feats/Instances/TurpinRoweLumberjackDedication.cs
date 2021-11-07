using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TurpinRoweLumberjackDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9d718e55-ec21-4f8a-b952-90cc574487f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Turpin Rowe Lumberjack Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Turpin Rowe lumberjack archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a913243-dfbb-409b-b119-bc4e68e27cb3"), Type = TextBlockType.Text, Text = "~ Access: You must befriend at least one Turpin Rowe logger." };
            yield return new TextBlock { Id = Guid.Parse("e1ba4757-5a3f-4218-b9ec-4ce62f080c9f"), Type = TextBlockType.Text, Text = "Your logging training has made you intimately familiar with all aspects of forestry, and you have trained extensively to reach around trees and utilize their bulk to your advantage. You become trained in Milling Lore and Forest Lore, or an expert if you were already trained. You can always (action: Take Cover) when you are within forest terrain to gain cover, even if you’re not next to an obstacle you can (action: Take Cover) behind. In addition, any enemy who gains standard cover from a tree gains only lesser cover against your attacks (or only standard cover, if the enemy otherwise gains greater cover)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("78afc6cf-bd57-4a22-aaab-d7825c9f3680"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("189d2200-a7be-4087-b436-18fe3f4861a9"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
