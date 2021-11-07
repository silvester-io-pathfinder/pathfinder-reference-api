using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SunsFury : Template
    {
        public static readonly Guid ID = Guid.Parse("fcf89831-e515-4e5e-b3a0-dc96a4d16f99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sun's Fury",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f01fa11-9756-4a72-b8bb-df79d312e378"), Type = TextBlockType.Text, Text = "The Old Sun Gods have granted you a gift in your fight against Walkena. You gain the (spell: sun’s fury) focus spell. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can regain using the (action: Refocus) activity to pray to the Old Sun Gods; if you already have a focus pool, increase the number of Focus Points in your focus pool by 1. Your Bright Lion focus spells are divine spells; when you gain this feat, if you aren’t already, you become trained in divine spell attacks and spell DCs, using Charisma as your spellcasting ability score." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fb031826-e372-4cc3-8ea1-416ce030744a"), Feats.Instances.BrightLionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4aee367c-c2df-4150-ae41-64210b257c5f"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
