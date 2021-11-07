using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnightVigilantDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("fe1e26a8-c35c-4d90-ac09-1e5ec693b135");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knight Vigilant Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Knight Vigilant archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4efaab62-cb27-40a4-902c-31ee6e2fafd5"), Type = TextBlockType.Text, Text = "You are dedicated to the cause of the Shining Sentinels. You gain expert proficiency in Religion. When you are between an ally and a foe and would provide lesser cover to your ally against the foe’s attacks, you twist to become even more obtrusive, providing standard cover instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("36c2566b-8361-40be-b0f2-508b48b5e886"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);
            builder.AddOr(Guid.Parse("aea9ea01-cd71-41f4-b149-585b592fd144"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("327b2fa0-2f35-4333-a32f-397dba0c7e7f"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("5e392133-dd58-496e-b609-498d6f200257"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("cf911d9c-2839-46ab-aa2c-e214d73d700c"), Alignments.Instances.NeutralGood.ID);
            });
            builder.Manual(Guid.Parse("019f8618-6362-4253-ab4f-7212a56ef9ac"), "Member of the Knights of Lastwall of knight rank.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("581d2e34-aada-4385-82f6-0bc0d6c96a37"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
