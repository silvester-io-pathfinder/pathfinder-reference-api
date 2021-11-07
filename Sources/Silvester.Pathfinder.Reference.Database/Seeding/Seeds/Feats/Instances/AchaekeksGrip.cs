using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AchaekeksGrip : Template
    {
        public static readonly Guid ID = Guid.Parse("ae56a494-101b-47b5-bacf-561ed93ef68c");

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
            yield return new TextBlock { Id = Guid.Parse("f3c3f6c5-bbe0-49aa-8f7c-c6f2d6d2d469"), Type = TextBlockType.Text, Text = "You sense if a creature you have slain in the last year has been restored to life, as long as you and that creature are on the same plane. You also gain the (spell: Achaekek’s clutch) focus spell. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) by praying to Achaekek or researching your assigned kill." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("725de647-8346-475c-8daf-f1282d35d99f"), Feats.Instances.BasicRedMantisMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4d05328-e068-4fd5-a6b5-1c34bb7f0226"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
