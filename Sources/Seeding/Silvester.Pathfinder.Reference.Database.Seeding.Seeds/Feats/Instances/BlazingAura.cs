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
    public class BlazingAura : Template
    {
        public static readonly Guid ID = Guid.Parse("dd7f8978-86ca-45fd-abec-722c1557acaa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blazing Aura",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98ac7b3e-50a8-4655-bae1-fedc5e777c5c"), Type = TextBlockType.Text, Text = $"You explode in flame. Enemies in a 20-foot emanation take 7d6 fire damage (basic Reflex save using your class DC or spell DC, whichever is higher). Allies in the area are quickened for 1 round and can use the additional action to {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} or {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d35b4aff-0418-42cc-9525-487d3edf7ca3"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("8363d31e-d71b-4d98-a4d7-bc5727afeef8"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("4c7fb5d4-9bb7-443c-a99a-637df75747b3"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("b209bdca-37b7-48c7-a9a0-df1b29c67b40"), Traits.Instances.Ifrit.ID);
            builder.Add(Guid.Parse("f13c91be-4b72-4b9d-913e-3886825c5028"), Traits.Instances.Primal.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a894b33-b351-4169-8b4a-68d59044926f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
