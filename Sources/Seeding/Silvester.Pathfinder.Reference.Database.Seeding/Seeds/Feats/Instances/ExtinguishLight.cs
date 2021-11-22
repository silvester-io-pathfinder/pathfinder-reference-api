using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExtinguishLight : Template
    {
        public static readonly Guid ID = Guid.Parse("b2f080d1-820d-46c6-b75f-8f4051560d50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Extinguish Light",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f130d9da-3db1-421d-878e-0b9317f57180"), Type = TextBlockType.Text, Text = "You wrap shadow around a single unattended light source within 120 feet that's no larger than a (item: torch). Any non-magical light source you target is automatically extinguished. For magical light sources, attempt a counteract check using your Fortitude or Thievery modifier against the target's DC. Your counteract level is equal to half your level rounded up. Successfully counteracting the light source suppresses its ability to produce light for 1 minute, but not any other effects. If you're in dim light or darkness when you Extinguish Light, its range is 240 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("602158ec-25a8-4669-a328-be4384003f55"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
