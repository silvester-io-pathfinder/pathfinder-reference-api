using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterfulObfuscation : Template
    {
        public static readonly Guid ID = Guid.Parse("1f68d84e-48ea-4c18-a7f1-80059bd83bc8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Masterful Obfuscation",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2dc39c44-0fed-4ad0-9435-a8023fe3b1ce"), Type = TextBlockType.Text, Text = "You've mastered the art of deceiving others about your area of study. When you gain this feat, choose one skill with the (action: Recall Knowledge) action in which you have attained master proficiency. You can attempt to deceive others about the truth of facts and knowledge related to that skill – such as by pretending to know something that you don't, planting false information, or the like – using the (action: Lie) action of the Deception skill." };
            yield return new TextBlock { Id = Guid.Parse("4195c90e-541c-47ff-a7cb-72505b9ce97e"), Type = TextBlockType.Text, Text = "When you (action: Lie) in this way, attempt your skill check using the skill you selected when you gained this feat instead of Deception, applying all bonuses or penalties related from the selected skill to the check. While it's easier to convince someone who knows nothing about your chosen false information, on a critical success, you can even convince someone who has heard something contradictory, unless they have reason to be certain from direct experience. For instance, you might say, “I know you may have heard to use silver weapons against vampires, but that's a misconception based on conflating them with werewolves. According to all credible scholars, cold iron will do the trick.”" };
            yield return new TextBlock { Id = Guid.Parse("9c6609e1-2b4f-4b21-b78d-d2c121fef950"), Type = TextBlockType.Text, Text = "Once a creature realizes you've used masterful obfuscation to (action: Lie) to them, either from a failed check or due to later discovering the falsehood, you can't use this feat against them again, as it relies on blind trust in your superior knowledge. However, you can still (action: Lie) to them normally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("863af7b8-ba7f-4fd3-9a6b-da2effb1bd07"), Proficiencies.Instances.Master.ID, requiresAssurance: false);
            builder.HaveSpecificFeat(Guid.Parse("55be8aaf-2bbb-4e0a-a4d2-848c16618471"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bacad54-860c-4190-b153-fda1e4659230"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
