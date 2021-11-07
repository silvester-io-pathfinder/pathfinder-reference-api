using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoEvidence : Template
    {
        public static readonly Guid ID = Guid.Parse("b95d13c3-8111-4f41-b5e5-087d7c5c5537");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No Evidence",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("387a54cd-5db2-4877-9fe9-9a9032923295"), Type = TextBlockType.Text, Text = "You leave little sign when attempting to remain unseen. When you (action: Avoid Notice), you also gain the benefits of (action: Cover Tracks) unless you choose not to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f510f77d-0d17-4b60-ad14-fd388ebb1021"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28e0b370-caf3-4bec-881f-ed4771bcbac4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
