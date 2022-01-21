using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MultifacetedPsyche : Template
    {
        public static readonly Guid ID = Guid.Parse("f5b903d7-a219-4046-b6d9-f931d200ec78");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multifaceted Psyche",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73d6ba86-c3fe-4e71-a887-b8eaac029ec8"), Type = TextBlockType.Text, Text = "You've uncovered so many facets of your psyche that you can bring two to the front when your mind is unleashed. If you've met the requirements for two psyche abilities, when you Unleash your psyche, you can enter both simultaneously, gaining both benefits and both drawbacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0eae51d-7840-46ac-ac59-5776bd681d11"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
