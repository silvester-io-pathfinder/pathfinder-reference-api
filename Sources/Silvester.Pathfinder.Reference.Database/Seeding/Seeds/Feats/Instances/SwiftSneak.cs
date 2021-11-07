using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwiftSneak : Template
    {
        public static readonly Guid ID = Guid.Parse("d606dcfe-5b10-4d84-a8f6-d1dfc0ac49b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swift Sneak",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7575139-a7c9-48e0-84b1-ce3fbb1e7717"), Type = TextBlockType.Text, Text = "You can move your full Speed when you (Action: Sneak). You can use Swift Sneak while (Action: Burrowing | Burrow), (Action: Climbing | Climb), (Action: Flying | Fly), or (Action: Swimming | Swim) instead of (Action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("203af9c6-2334-48b3-9444-4dc354286155"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("baaa954d-576e-415d-87a5-a5e7293e384c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
