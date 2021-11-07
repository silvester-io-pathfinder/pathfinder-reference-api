using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaturalMedicine : Template
    {
        public static readonly Guid ID = Guid.Parse("6087acc1-c551-48b7-a5aa-a4b52f0bcc91");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Natural Medicine",
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
            yield return new TextBlock { Id = Guid.Parse("cb6e228a-2b19-4c76-8ea5-5a92684c13d5"), Type = TextBlockType.Text, Text = "You can apply natural cures to heal your allies. You can use Nature instead of Medicine to (Action: Treat Wounds). If you’re in the wilderness, you might have easier access to fresh ingredients, allowing you to gain a +2 circumstance bonus to your check to (Action: Treat Wounds) using Nature, subject to the GM’s determination." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("92dc3b05-febb-4c20-8a71-33a8ff7953d6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcac1d51-62f7-413d-b5f7-68f0c16acf76"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
