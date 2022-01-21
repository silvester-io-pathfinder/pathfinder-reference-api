using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendarySneak : Template
    {
        public static readonly Guid ID = Guid.Parse("4e4fa44b-c00a-4c99-8119-979eb3e796b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Sneak",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7eccff3-850a-4039-8ddc-bced109ebf30"), Type = TextBlockType.Text, Text = "You're always sneaking unless you choose to be seen, even when there's nowhere to hide. You can (Action: Hide) and (Action: Sneak) even without cover or being concealed. When you employ an exploration tactic other than (Action: Avoiding Notice | Avoid Notice), you also gain the benefits of (Action: Avoiding Notice | Avoid Notice) unless you choose not to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("be670a18-cea4-4baf-a107-082e85968249"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificFeat(Guid.Parse("fef16683-01f8-4f4a-a402-7b17dac3bbd0"), Feats.Instances.SwiftSneak.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c51f004-8656-4691-85b2-eaf3f324c321"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
