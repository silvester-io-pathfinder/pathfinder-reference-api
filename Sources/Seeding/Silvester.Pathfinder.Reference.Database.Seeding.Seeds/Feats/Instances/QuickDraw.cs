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
    public class QuickDraw : Template
    {
        public static readonly Guid ID = Guid.Parse("06cee945-f4fa-4155-b472-6d4a9ea085aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Draw",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("67f0e815-8959-4a34-82c0-5f21e9ffa5ba"), Type = TextBlockType.Text, Text = $"You draw your weapon and attack with the same motion. You {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw a weapon, then {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with that weapon." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("adad2a02-338a-4ee2-8b13-aa4339b9139b"), Traits.Instances.Gunslinger.ID);
            builder.Add(Guid.Parse("9cb4d6be-6989-429f-af5f-8c1092a8206d"), Traits.Instances.Ranger.ID);
            builder.Add(Guid.Parse("a5d9227f-514c-4b8e-abed-d3f1002f3a38"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9760e4e-b195-4011-b3e8-1cea9f2534dd"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
