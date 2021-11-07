using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShallNotRoutShallNotFalter : Template
    {
        public static readonly Guid ID = Guid.Parse("50366c40-45f2-48a6-b16d-cc3887f8d437");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shall Not Rout, Shall Not Falter",
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
            yield return new TextBlock { Id = Guid.Parse("a4bbd579-162b-44c6-b72f-9598b7c2515d"), Type = TextBlockType.Text, Text = "You gain the (spell: shall not rout, shall not falter) focus spell. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can regain using the (action: Refocus) activity to recite the Crimson Oath and meditate on its teachings. If you already have a focus pool, increase the number of Focus Points in your focus pool by 1. Your knight reclaimant focus spells are divine spells; when you gain this feat, you become trained in divine spell attacks and spell DCs and your spellcasting ability is Charisma." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("13fd6f58-3464-434a-9af3-5010171306f4"), Feats.Instances.KnightReclaimantDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab119e25-459a-4ff8-a149-957b46d64a63"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
