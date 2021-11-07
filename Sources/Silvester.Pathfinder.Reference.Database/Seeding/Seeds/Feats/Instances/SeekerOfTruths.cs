using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeekerOfTruths : Template
    {
        public static readonly Guid ID = Guid.Parse("8635199a-f4ba-40e0-8a2f-dbfed267b7d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seeker of Truths",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat up to three times, selecting a different domain each time.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa8d9089-9c83-4100-8f21-7db42bc91d5f"), Type = TextBlockType.Text, Text = "Your devotion to discovering and hoarding abstruse truths borders on the fanatical, and you can bring this devotion to bear. You gain the cleric&#39;s (feat: Domain Initiate) feat but must select knowledge, secrecy, or truth as your domain. You cast that domain&#39;s domain spell as a focus spell of the same tradition as your cantrip from Eldritch Researcher Dedication, and you (action: Refocus) by contemplating abstruse mysteries rather than praying to a god. When an ability would manifest a divine symbol—such as the word of truth focus spell—it instead manifests as a strange shape unique to you that seems to defy geometry." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9e4ee0db-189a-4614-b82f-96e1d793067f"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14438b6b-a850-4f55-8015-e83b82253630"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
