using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HellknightDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("bc819f38-ca71-418f-aa38-9897b854d72e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hellknight Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Hellknight or Hellknight armiger archetypes.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2516bae-eab9-470e-9fa4-193cdf16e34d"), Type = TextBlockType.Text, Text = "You have forged your body to comply with the commands of your mind – orders steeped in the Measure and the Chain. You gain expert proficiency in Intimidation (or in another skill in which you’re trained of your choice, if you were already an expert in Intimidation). You gain the armor specialization effects of Hellknight plate, and your resistance from that armor specialization is 1 higher than normal. In addition, you gain a +1 circumstance bonus to Intimidation checks while wearing your Hellknight plate." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("371652a9-014e-4829-9d30-9f4a5019737b"), Feats.Instances.HellknightArmigerDedication.ID);
            builder.AddOr(Guid.Parse("a16ee1a1-5867-4259-a4fc-c81428414f65"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("e47a34d0-7273-4c21-836d-5d0d2afa8b6b"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("af24f1e2-4438-4ef8-a705-f74e97c0e055"), Alignments.Instances.LawfulEvil.ID);
            });
            builder.Manual(Guid.Parse("91e0200e-fafa-4268-b8a6-70417ef49d33"), "Member of a Hellknight order.");
            builder.Manual(Guid.Parse("dc5ff531-16c1-4f90-be56-bc027d6b7a22"), "Passed the Hellknight Test.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e65fbeee-ddbc-470a-9a43-9c43a2299416"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
