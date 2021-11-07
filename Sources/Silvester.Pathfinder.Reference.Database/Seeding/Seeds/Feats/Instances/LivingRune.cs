using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("5ce08af2-916c-4d01-b1e6-926ba550ee14");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Living Rune",
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
            yield return new TextBlock { Id = Guid.Parse("da78ab69-b76d-4b3f-871a-0c8fadb33e65"), Type = TextBlockType.Text, Text = "You’ve bridged a connection between the runes on your body and the magic of runestones, allowing you to place an armor rune on your living flesh. Your body can hold a single property rune; you can’t etch a property rune on your body if it has requirements on the type or category of armor or if the property would affect the armor instead of its wearer. If you wear armor, you gain the property rune’s effects in addition to any effects of that armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("df415898-fbed-4295-b033-67f57b159289"), Feats.Instances.RunescarredDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11130142-1fed-41dc-bd5f-1f833dbe1cf4"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
