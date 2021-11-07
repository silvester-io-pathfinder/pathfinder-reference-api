using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AchaekeksGrip : Template
    {
        public static readonly Guid ID = Guid.Parse("0da2222b-d313-4d97-b3f0-1ce6a7b1a5b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Achaekek's Grip",
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
            yield return new TextBlock { Id = Guid.Parse("faaed5f2-d629-4235-b8d5-9309c30d1862"), Type = TextBlockType.Text, Text = "You sense if a creature you have slain in the last year has been restored to life, as long as you and that creature are on the same plane. You also gain the (spell: Achaekek’s clutch) focus spell. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) by praying to Achaekek or researching your assigned kill." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("89f81080-fe52-4b58-a406-2802f9858c37"), Feats.Instances.BasicRedMantisMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcf86ace-1da2-4243-8ec6-d3680a63c354"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
