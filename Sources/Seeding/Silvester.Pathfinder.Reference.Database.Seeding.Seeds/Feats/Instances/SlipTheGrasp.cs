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
    public class SlipTheGrasp : Template
    {
        public static readonly Guid ID = Guid.Parse("22843e50-27ed-4866-a29a-f87239d653b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slip the Grasp",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c4e0b46d-ebff-46ea-82d4-8c6202cc20ec"), Type = TextBlockType.Text, Text = $"You have some feature that allows you to quickly evade effects that restrain you. Attempt a check to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)}. If you succeed, you can {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}, or make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a melee unarmed attack targeting the creature you {ToMarkdownLink<Models.Entities.Action>("Escaped", Actions.Instances.Escape.ID)} from. If you fail, you instead attempt to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} a second time." };
            yield return new TextBlock { Id = Guid.Parse("6ea6832c-0737-4aaa-b324-5b94e525ba55"), Type = TextBlockType.Text, Text = $"You increase your multiple attack penalty as appropriate for the actions you took, but only after completing both actions." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fleshwarp.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d28d9e45-4eb8-447c-b47f-36ba8c9f1bb5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
