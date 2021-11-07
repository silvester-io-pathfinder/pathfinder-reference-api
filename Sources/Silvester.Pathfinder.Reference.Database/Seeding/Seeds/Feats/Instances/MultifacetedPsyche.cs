using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MultifacetedPsyche : Template
    {
        public static readonly Guid ID = Guid.Parse("638c7d55-5f75-4090-a72c-f162165c925c");

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
            yield return new TextBlock { Id = Guid.Parse("3f10315f-4f81-40a0-ae72-826e2e8db50e"), Type = TextBlockType.Text, Text = "You’ve uncovered so many facets of your psyche that you can bring two to the front when your mind is unleashed. If you’ve met the requirements for two psyche abilities, when you Unleash your psyche, you can enter both simultaneously, gaining both benefits and both drawbacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7300113-37e0-4e4d-9f1e-e1af42df6214"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
