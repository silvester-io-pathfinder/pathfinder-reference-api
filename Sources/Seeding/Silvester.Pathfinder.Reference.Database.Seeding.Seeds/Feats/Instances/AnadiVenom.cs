using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnadiVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("fdb1e16a-88cc-432a-935f-c75c024bbc65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anadi Venom",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "a number of times per day equal to your level"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7a2c5c1f-3af4-4b47-bf6a-35453e2fceca"), Type = TextBlockType.Text, Text = $"You envenom your fangs. If the next fangs {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} you make before the end of your turn hits and deals damage, the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals an additional 1d6 poison damage. On a critical failure, the poison is wasted as normal. At 12th level, this poison damage increases to 2d6." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e10d196d-644a-4adc-ac58-d62bed07e90c"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
