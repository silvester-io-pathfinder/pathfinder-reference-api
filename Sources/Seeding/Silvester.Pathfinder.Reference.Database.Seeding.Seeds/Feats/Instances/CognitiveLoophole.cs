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
    public class CognitiveLoophole : Template
    {
        public static readonly Guid ID = Guid.Parse("f026c2b7-afe3-41f5-b088-d11638a7b72d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cognitive Loophole",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can use this reaction even if the mental effect is preventing you from using reactions.",
                Trigger = "Your turn ends.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4bc325b-e54d-40fb-a053-ed1fde67e7c8"), Type = TextBlockType.Text, Text = $"You can find a loophole in a mental effect to temporarily overcome it. Until the end of your next turn, you ignore a single {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} effect that meets the requirement. You can suppress a particular effect using Cognitive Loophole only once." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("38f49792-0631-45b3-b730-fb5060a493c8"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3817110-5b5e-4a95-b7dc-30411063aa42"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
