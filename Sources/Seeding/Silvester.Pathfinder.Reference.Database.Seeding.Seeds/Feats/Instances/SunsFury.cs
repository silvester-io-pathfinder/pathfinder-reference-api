using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SunsFury : Template
    {
        public static readonly Guid ID = Guid.Parse("ebf85b9d-bf9a-4c4e-9a07-a40ab6b59cbb");

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
            yield return new TextBlock { Id = Guid.Parse("cac7cb0c-1fa7-4e41-b21b-08b2cbf19c32"), Type = TextBlockType.Text, Text = "The Old Sun Gods have granted you a gift in your fight against Walkena. You gain the (spell: sun's fury) focus spell. If you don't already have one, you gain a focus pool of 1 Focus Point, which you can regain using the (action: Refocus) activity to pray to the Old Sun Gods; if you already have a focus pool, increase the number of Focus Points in your focus pool by 1. Your Bright Lion focus spells are divine spells; when you gain this feat, if you aren't already, you become trained in divine spell attacks and spell DCs, using Charisma as your spellcasting ability score." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8d4efff2-a5d1-4a8d-88bf-e7029b61e197"), Feats.Instances.BrightLionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("97eb44e8-b36c-433c-a616-cdf28a34e993"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
