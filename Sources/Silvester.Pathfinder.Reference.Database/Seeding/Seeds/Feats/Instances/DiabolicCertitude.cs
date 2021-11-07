using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiabolicCertitude : Template
    {
        public static readonly Guid ID = Guid.Parse("c31ac67e-79e8-4dc1-895c-3a69b43bbe65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diabolic Certitude",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins and you can observe a devil.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2ce71ee-c8b2-494b-abf8-e0ab67e608bb"), Type = TextBlockType.Text, Text = "Your Hellknight training drilled details of Hell’s denizens deep into your mind. Make an attempt to (action: Recall Knowledge) about a devil you’re observing. If you roll a critical failure on this check, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6d69c19f-01f4-499d-aa1f-891e483bd89c"), Feats.Instances.HellknightArmigerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95888733-0f9a-46a2-8aa7-c9a50fe999d7"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
