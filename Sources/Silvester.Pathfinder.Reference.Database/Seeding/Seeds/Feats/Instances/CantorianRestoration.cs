using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CantorianRestoration : Template
    {
        public static readonly Guid ID = Guid.Parse("a15e65af-2b96-413e-bd7a-3c066f957ed0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cantorian Restoration",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A living creature within 60 feet would die.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b5c4763-b4c9-4372-ae42-716833719249"), Type = TextBlockType.Text, Text = "The energy that flows in your blood can save a life in the direst of times. The triggering creature receives the effects of (spell: breath of life), except they recover a number of Hit Points equal to 6d8 plus your Constitution modifier." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ff63283-937f-47dd-b83d-dae1fbb62707"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
