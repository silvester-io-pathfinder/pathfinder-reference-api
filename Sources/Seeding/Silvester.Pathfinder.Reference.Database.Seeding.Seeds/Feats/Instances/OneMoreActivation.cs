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
    public class OneMoreActivation : Template
    {
        public static readonly Guid ID = Guid.Parse("d327888a-d500-4ceb-85fe-b9f67eaab8e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One More Activation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1b27399-df74-49bd-8a68-4fb6392f0ecd"), Type = TextBlockType.Text, Text = $"You've forged a deeper connection to your invested items, allowing you to activate them more than usual. Once each day, you can activate an item you've invested even after you've used that activation the maximum number of times for its frequency. You can do so only if the item's level is half your level or lower, has a frequency of once per day or more, and you haven't already used the activation this round." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a9e42d9-6343-4ebf-b75a-5dbd346d7a0e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
