using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterfulObfuscation : Template
    {
        public static readonly Guid ID = Guid.Parse("f477947f-0849-49a9-a41d-35eb9aa189c2");

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
            yield return new TextBlock { Id = Guid.Parse("878c76e1-6a3c-4fb9-ac5e-cb867cbf204d"), Type = TextBlockType.Text, Text = "You&#39;ve mastered the art of deceiving others about your area of study. When you gain this feat, choose one skill with the (action: Recall Knowledge) action in which you have attained master proficiency. You can attempt to deceive others about the truth of facts and knowledge related to that skill – such as by pretending to know something that you don&#39;t, planting false information, or the like – using the (action: Lie) action of the Deception skill." };
            yield return new TextBlock { Id = Guid.Parse("f432c105-9b37-40f6-802c-cbd84d41d5f5"), Type = TextBlockType.Text, Text = "When you (action: Lie) in this way, attempt your skill check using the skill you selected when you gained this feat instead of Deception, applying all bonuses or penalties related from the selected skill to the check. While it&#39;s easier to convince someone who knows nothing about your chosen false information, on a critical success, you can even convince someone who has heard something contradictory, unless they have reason to be certain from direct experience. For instance, you might say, “I know you may have heard to use silver weapons against vampires, but that&#39;s a misconception based on conflating them with werewolves. According to all credible scholars, cold iron will do the trick.”" };
            yield return new TextBlock { Id = Guid.Parse("2f06d6e9-5126-4c5b-bddf-1eb920be47ee"), Type = TextBlockType.Text, Text = "Once a creature realizes you&#39;ve used masterful obfuscation to (action: Lie) to them, either from a failed check or due to later discovering the falsehood, you can&#39;t use this feat against them again, as it relies on blind trust in your superior knowledge. However, you can still (action: Lie) to them normally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("6b0015ba-3e8a-4f39-b8cb-b0dc49751281"), Proficiencies.Instances.Master.ID, requiresAssurance: False);
            builder.HaveSpecificFeat(Guid.Parse("4e944130-eaa9-4e88-ae69-d638493a850b"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a50a8448-fa1b-4431-adf9-de9863e4b6e8"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
