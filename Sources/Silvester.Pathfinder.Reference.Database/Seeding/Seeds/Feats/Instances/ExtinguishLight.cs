using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExtinguishLight : Template
    {
        public static readonly Guid ID = Guid.Parse("4e3e236c-94d4-4a10-a833-59069b72c298");

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
            yield return new TextBlock { Id = Guid.Parse("17e4ed36-674d-4a6c-8036-5c736d191c78"), Type = TextBlockType.Text, Text = "You wrap shadow around a single unattended light source within 120 feet that’s no larger than a (item: torch). Any non-magical light source you target is automatically extinguished. For magical light sources, attempt a counteract check using your Fortitude or Thievery modifier against the target’s DC. Your counteract level is equal to half your level rounded up. Successfully counteracting the light source suppresses its ability to produce light for 1 minute, but not any other effects. If you’re in dim light or darkness when you Extinguish Light, its range is 240 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62a1a828-3858-498b-91b6-e85a237f9461"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
