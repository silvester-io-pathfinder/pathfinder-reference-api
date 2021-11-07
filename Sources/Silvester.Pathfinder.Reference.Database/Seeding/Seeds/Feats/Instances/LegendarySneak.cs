using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendarySneak : Template
    {
        public static readonly Guid ID = Guid.Parse("997755b1-99a6-468e-9c2f-0459cc10fe9b");

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
            yield return new TextBlock { Id = Guid.Parse("218899cd-5e80-4b74-881f-0d97bc3876e0"), Type = TextBlockType.Text, Text = "You’re always sneaking unless you choose to be seen, even when there’s nowhere to hide. You can (Action: Hide) and (Action: Sneak) even without cover or being concealed. When you employ an exploration tactic other than (Action: Avoiding Notice | Avoid Notice), you also gain the benefits of (Action: Avoiding Notice | Avoid Notice) unless you choose not to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6a020ff4-081e-4190-a44c-5be0b116216a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificFeat(Guid.Parse("2b17d622-0e40-4623-bc72-0e96bed854c0"), Feats.Instances.SwiftSneak.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bb4933e-9576-4690-bfed-af8e070b66de"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
