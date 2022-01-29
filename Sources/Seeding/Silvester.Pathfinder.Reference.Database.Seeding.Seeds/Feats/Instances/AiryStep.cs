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
    public class AiryStep : Template
    {
        public static readonly Guid ID = Guid.Parse("1a772a3f-a5b7-40c6-bb4a-4c62a3583e89");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Airy Step",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature targets you with an attack or other targeted effect, and you can see the attacker.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cd804b6-6ad5-448d-a38c-9a7df578f484"), Type = TextBlockType.Text, Text = $"You create a blanket of fog in a 5-foot burst centered on one corner of your space. All creatures within that area are concealed, and all others are concealed to them. This concealment applies to the triggering effect, and the fog lasts for 1 minute or until dispersed by a strong wind. After resolving the triggering effect, you {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}. If an effect prevents you from {ToMarkdownLink<Models.Entities.Action>("Stepping", Actions.Instances.Step.ID)}, you attempt to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} the effect and {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} if you succeed." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Sylph.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd1f2f29-80ae-4c75-bac9-280baf48bbe2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
