using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnightVigilantDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("e66bd30c-4978-43df-be7c-588b2ff5db2c");

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
            yield return new TextBlock { Id = Guid.Parse("fffab088-9e51-46f3-b87f-032a2516b646"), Type = TextBlockType.Text, Text = "You are dedicated to the cause of the Shining Sentinels. You gain expert proficiency in Religion. When you are between an ally and a foe and would provide lesser cover to your ally against the foe's attacks, you twist to become even more obtrusive, providing standard cover instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d1f035ad-a361-45f6-9aa7-c79ad7b6e4ec"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);
            builder.AddOr(Guid.Parse("0d4dbd93-d604-464d-842b-2055c3aa1d51"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("db054e4a-d660-4c9a-8802-41977d4ce5de"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("533eed7a-d54b-408d-8627-f072eeb9de20"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("95cbcd68-77d7-4f73-a394-4aedb10c7c40"), Alignments.Instances.NeutralGood.ID);
            });
            builder.Manual(Guid.Parse("b1dbfd70-9d77-411c-b303-de828ed92308"), "Member of the Knights of Lastwall of knight rank.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb699845-3d03-42ba-a210-d551b53ff28a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
