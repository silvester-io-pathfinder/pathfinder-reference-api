using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollTricksterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("4109df55-bfff-47f2-9e30-308078acd2aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scroll Trickster Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the scroll trickster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c47e6f7b-2fee-4829-902a-779dcd3adbca"), Type = TextBlockType.Text, Text = "You’ve studied scrolls in depth. This might have been a comprehensive education in formal setting, or the sort of education where you somehow obtain a number of scrolls and try not to explode anything you didn’t mean to explode. You gain the (feat: Trick Magic Item) feat, and you gain a +2 circumstance bonus to skill checks to (feat: Trick | Trick Magic Item) scrolls. If you roll a critical failure to (feat: Trick a Magic Item | Trick Magic Item) that’s a scroll, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("eaba354b-3b27-446e-b646-85e0299a37ee"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("54303e53-b603-43f9-91ac-87db6a4bb9eb"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("b0717ace-ebd9-437d-8f5e-c91ad0d7b048"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("743c18ee-153c-4cd1-9834-29b0e910f306"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("fcd90a97-f208-4a4e-a526-414d273cef65"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba440cf4-9deb-470e-b4f3-59c698b941c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
