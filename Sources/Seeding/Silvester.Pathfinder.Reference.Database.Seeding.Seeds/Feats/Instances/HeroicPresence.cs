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
    public class HeroicPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("c11467f7-b9b6-4bc0-8dd3-878aae8603b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heroic Presence",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0c36d53-af1e-4748-9657-2f010d0adaab"), Type = TextBlockType.Text, Text = $"The blood of heroes courses through your veins, and you inspire your allies to dig deep and find a new level of resolve. You grant up to 10 willing creatures within 30 feet the effects of a 6th-level {ToMarkdownLink<Models.Entities.Spell>("zealous conviction", Spells.Instances.ZealousConviction.ID)}, though the effect automatically ends on a target if you give that target a command they would normally find repugnant. This action has the {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} trait or {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} trait, depending on how you inspire your allies." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Human.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Mental.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("397d1ab5-2594-4624-8cf1-5667f7a06964"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
