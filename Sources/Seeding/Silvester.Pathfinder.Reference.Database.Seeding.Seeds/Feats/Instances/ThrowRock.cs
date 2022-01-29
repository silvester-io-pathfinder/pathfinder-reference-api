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
    public class ThrowRock : Template
    {
        public static readonly Guid ID = Guid.Parse("023bd31b-2eca-40ab-869e-ace685e4f69c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Throw Rock",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d45dd75c-b93e-4589-aa9b-4114bf9deb7c"), Type = TextBlockType.Text, Text = $"The arboreal sapling {ToMarkdownLink<Models.Entities.Action>("Interacts", Actions.Instances.Interact.ID)} to pick up a rock within reach or retrieve a stowed rock, then throws it with a ranged rock {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} that deals a base of 1d6 bludgeoning damage with a range increment of 30 feet." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6846ebb-4010-422d-af45-e8bc482fd660"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
