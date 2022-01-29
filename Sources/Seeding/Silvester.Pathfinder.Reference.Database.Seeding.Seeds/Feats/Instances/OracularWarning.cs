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
    public class OracularWarning : Template
    {
        public static readonly Guid ID = Guid.Parse("c5cc32c8-f35b-4444-9ef1-5ed57857429a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oracular Warning",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a7a8146-2547-42e4-ac2a-d952dbe716ea"), Type = TextBlockType.Text, Text = $"You have a flash of insight about impending danger related to one ally, and you can shout or gesture to warn that ally of the threat a moment before it materializes. One ally of your choice can roll twice for initiative and use the better result; this is a {ToMarkdownLink<Models.Entities.Trait>("fortune", Traits.Instances.Fortune.ID)} effect. If you are legendary in Religion, you receive two visions and can warn two allies, granting them both this benefit." };
            yield return new TextBlock { Id = Guid.Parse("82ca32ba-d531-4232-aa4c-f09ebdae5486"), Type = TextBlockType.Text, Text = $"You are momentarily thrown off by the divine insight, however, and you must roll twice for your initiative roll and use the worse result. This is a {ToMarkdownLink<Models.Entities.Trait>("misfortune", Traits.Instances.Misfortune.ID)} effect. The two effects are tied together; if you would avoid the misfortune effect for any reason, or if any of your allies would negate their fortune effect, your Oracular Warning does nothing. Depending on whether you use gestures or call out, this action gains either the {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} or {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} trait, respectively." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("61ce73bd-a6d8-494d-a1e6-fe5e5c195024"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("88af1a54-9a98-4dc5-bcad-5574a9294d39"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("fa3fe6d3-0a6b-4cf2-9698-36acc3305f61"), Traits.Instances.Oracle.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30a26210-9f43-4110-be2c-a9e1d6ea3623"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
