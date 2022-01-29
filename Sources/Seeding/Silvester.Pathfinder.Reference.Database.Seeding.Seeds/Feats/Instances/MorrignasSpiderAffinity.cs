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
    public class MorrignasSpiderAffinity : Template
    {
        public static readonly Guid ID = Guid.Parse("badcdbaf-8ae8-41de-a699-95d5783ff9e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Morrigna's Spider Affinity",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7777a38c-29f0-4834-90c8-e9558395c7d7"), Type = TextBlockType.Text, Text = $"Much like morrignas, you feel an affinity for spiders. You can cast {ToMarkdownLink<Models.Entities.Spell>("animal messenger", Spells.Instances.AnimalMessenger.ID)} (spiders only), {ToMarkdownLink<Models.Entities.Spell>("speak with animals", Spells.Instances.SpeakWithAnimals.ID)} (spiders only), and {ToMarkdownLink<Models.Entities.Spell>("spider climb", Spells.Instances.SpiderClimb.ID)} each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("79245be2-f37b-49d5-8a6d-3efb3437d5e3"), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4349fe52-5a43-4ac2-8236-233f3d3134cf"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
