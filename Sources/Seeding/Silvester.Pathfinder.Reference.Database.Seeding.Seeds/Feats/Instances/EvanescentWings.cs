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
    public class EvanescentWings : Template
    {
        public static readonly Guid ID = Guid.Parse("ac4b91ed-918d-4365-995a-36f9c0188b76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Evanescent Wings",
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
            yield return new TextBlock { Id = Guid.Parse("56545b54-7385-4d15-8765-c85aee532850"), Type = TextBlockType.Text, Text = $"You've manifested wings that can flutter for brief spurts. You don't need to spend any additional actions to reach something in your space that a Medium creature could reach. For instance, if you wanted to open a cookie jar located four feet off the ground, you only need to spend a single {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action to do so. When you use Evanescent Wings to flutter to a higher place in your space, your action gains the {ToMarkdownLink<Models.Entities.Trait>("move", Traits.Instances.Move.ID)} trait." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("90daecd2-cfe6-4fdf-9923-48b37751413e"), Traits.Instances.Sprite.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f4db7e0-34bf-4428-9e87-ec56275dad74"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
