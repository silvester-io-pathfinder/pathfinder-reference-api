using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvokeTheCrimsonOath : Template
    {
        public static readonly Guid ID = Guid.Parse("8331cccf-4671-46ff-ae26-8c0d78e06af1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invoke the Crimson Oath",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0de9acbe-c976-4ac4-a839-00660c033990"), Type = TextBlockType.Text, Text = "You can invoke the Crimson Oath to unleash blasts of ruby energy from your weapon. You gain the (spell: invoke the Crimson Oath) focus spell. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can regain using the (action: Refocus) activity to recite the Crimson Oath and meditate on its teachings; if you already have a focus pool, increase the number of Focus Points in your focus pool by 1. Your knight reclaimant focus spells are divine spells; when you gain this feat, you become trained in divine spell attacks and spell DCs." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("89492f8d-dd64-4728-921e-914c79d6f469"), Feats.Instances.KnightReclaimantDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b4a206f-99b9-4924-be7d-6260236c4ebe"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
