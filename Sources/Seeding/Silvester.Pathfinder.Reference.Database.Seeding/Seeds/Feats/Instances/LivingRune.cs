using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("7e24fa26-d37e-4bfd-9dd5-5aa5bfbf93fe");

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
            yield return new TextBlock { Id = Guid.Parse("b6813509-5d18-4c26-99eb-b78095dd7862"), Type = TextBlockType.Text, Text = "You’ve bridged a connection between the runes on your body and the magic of runestones, allowing you to place an armor rune on your living flesh. Your body can hold a single property rune; you can’t etch a property rune on your body if it has requirements on the type or category of armor or if the property would affect the armor instead of its wearer. If you wear armor, you gain the property rune’s effects in addition to any effects of that armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("15a3cc57-a3ec-4814-8d16-e72633a97f3e"), Feats.Instances.RunescarredDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7f3bc11-d754-49df-ba9e-0b3dfd8bc1e7"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
