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
    public class Truespeech : Template
    {
        public static readonly Guid ID = Guid.Parse("a6808dc8-9e61-438e-a95e-d3a7eea65b76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Truespeech",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cda878ba-5804-41cc-bf79-d11e851aed89"), Type = TextBlockType.Text, Text = $"It is paramount that you are understood and you understand others; language need not impede your message. You can cast {ToMarkdownLink<Models.Entities.Spell>("tongues", Spells.Instances.Tongues.ID)} as a 5th-level divine innate spell once per day on yourself only. You gain a +1 status bonus to Diplomacy checks for the duration of the spell when speaking to creatures with whom you already shared a language before casting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6bedc4bb-0cd9-426c-85b6-18a3d4186118"), Feats.Instances.Angelkin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a9fa2b41-1e0a-4544-97f0-0e7ad4ec3e23"), Traits.Instances.Aasimar.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9b76dc2-4cf0-4e37-8a80-8f81626f1f12"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
