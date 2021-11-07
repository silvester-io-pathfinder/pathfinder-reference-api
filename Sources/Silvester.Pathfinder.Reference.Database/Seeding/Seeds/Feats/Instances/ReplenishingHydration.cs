using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReplenishingHydration : Template
    {
        public static readonly Guid ID = Guid.Parse("661d9741-9cab-4ff7-b70b-5f0deb7b6d00");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Replenishing Hydration",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ff15126-393e-4132-a900-5061f01d1aa0"), Type = TextBlockType.Text, Text = "You draw life from the water around you. If you submerge in water and rest for 10 minutes, you regain Hit Points equal to your Constitution modifier &#215; half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae597a97-e8d3-4ff7-b4d5-64e909db56a0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
