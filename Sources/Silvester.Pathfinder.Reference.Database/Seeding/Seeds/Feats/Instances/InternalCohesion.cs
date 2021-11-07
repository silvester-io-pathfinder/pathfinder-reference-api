using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InternalCohesion : Template
    {
        public static readonly Guid ID = Guid.Parse("84c9f475-6ffc-4311-aa69-adc93abcadcb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Internal Cohesion",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3bc90de-756b-4321-a83f-a1cc4242cf40"), Type = TextBlockType.Text, Text = "Axis’s order suffuses your body and helps it maintain coherency. You and your allies can (action: Treat your Wounds | Treat Wounds) without (item: healer’s tools). Once per day, when someone rolls a failure or a critical failure on a check to (action: Treat your Wounds | Treat Wounds), you can focus on your internal cohesion to increase the degree of success by one step." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bcfced77-e247-44dc-bc10-357082b60bcb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
