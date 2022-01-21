using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TurpinRoweLumberjackDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("622af1a2-adc2-481e-8b2d-da1cb8d48a2b");

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
            yield return new TextBlock { Id = Guid.Parse("1144eaad-babe-45ba-8f3b-ef3a1a7deb5b"), Type = TextBlockType.Text, Text = "~ Access: You must befriend at least one Turpin Rowe logger." };
            yield return new TextBlock { Id = Guid.Parse("66819028-ab5d-4c5c-951b-a06b54226ca2"), Type = TextBlockType.Text, Text = "Your logging training has made you intimately familiar with all aspects of forestry, and you have trained extensively to reach around trees and utilize their bulk to your advantage. You become trained in Milling Lore and Forest Lore, or an expert if you were already trained. You can always (action: Take Cover) when you are within forest terrain to gain cover, even if you're not next to an obstacle you can (action: Take Cover) behind. In addition, any enemy who gains standard cover from a tree gains only lesser cover against your attacks (or only standard cover, if the enemy otherwise gains greater cover)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e031030b-db1f-4ab3-bd3b-26455d26ce3f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fcc6834-3da1-42fa-9a0b-aabbd6556786"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
