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
    public class AzataMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("76a708a7-d28b-4b81-a78f-aaa4e250b03c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azata Magic",
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
            yield return new TextBlock { Id = Guid.Parse("4706ffa4-ca54-4c2c-8776-6dd45a53ffd4"), Type = TextBlockType.Text, Text = $"Your lineage traces back to the realm of Elysium, and you can harness its magic using this connection. You can cast {ToMarkdownLink<Models.Entities.Spell>("glitterdust", Spells.Instances.Glitterdust.ID)} and {ToMarkdownLink<Models.Entities.Spell>("remove paralysis", Spells.Instances.RemoveParalysis.ID)} each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ad6dbb7d-afd5-405d-ba5f-3aa6bda9695c"), Feats.Instances.Musetouched.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8741a4a1-0de4-4724-abae-133834a550a2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
