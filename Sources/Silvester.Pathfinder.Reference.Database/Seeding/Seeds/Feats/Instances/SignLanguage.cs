using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SignLanguage : Template
    {
        public static readonly Guid ID = Guid.Parse("74bbc83f-3bff-4ded-b4e6-244a71e12ac2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sign Language",
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
            yield return new TextBlock { Id = Guid.Parse("071b6f11-b10b-4247-a48a-6802a90d9861"), Type = TextBlockType.Text, Text = "You learn the sign languages associated with the languages you know, allowing you to sign and understand signs. Sign languages typically require both hands to convey more complex concepts, and they are visual rather than auditory." };
            yield return new TextBlock { Id = Guid.Parse("6ffc751f-a3e1-44d1-a157-908e2d7c1529"), Type = TextBlockType.Text, Text = "Sign language is difficult to understand during combat due to the level of attention needed, unlike basic gestures like pointing at a foe to suggest a target. Sign language is hard to use in areas of low visibility, just like speech is difficult in a noisy environment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c431ad5f-7de4-4db7-81f1-5aa4536ec837"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c3281f4-96f0-4b9d-ac34-4a45b7d207d9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
