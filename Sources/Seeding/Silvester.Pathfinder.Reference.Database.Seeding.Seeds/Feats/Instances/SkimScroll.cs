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
    public class SkimScroll : Template
    {
        public static readonly Guid ID = Guid.Parse("0608d5ea-3353-427d-9662-94fbbab51186");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skim Scroll",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("545ec77f-9bee-4ed6-b4fe-1394998d271c"), Type = TextBlockType.Text, Text = $"You can activate the magic of a scroll with a cursory read as you draw it from your belt. You {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw forth a scroll, then use {ToMarkdownLink<Models.Entities.Feat>("Trick Magic Item", Feats.Instances.TrickMagicItem.ID)} on the scroll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("33ae023e-97c2-4f68-a4b1-16873451bd87"), Feats.Instances.ScrollTricksterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c5a41b7-4a64-4461-be52-9b4207c18d23"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
