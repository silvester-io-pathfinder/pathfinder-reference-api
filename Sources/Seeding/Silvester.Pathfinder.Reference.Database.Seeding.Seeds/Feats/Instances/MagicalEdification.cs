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
    public class MagicalEdification : Template
    {
        public static readonly Guid ID = Guid.Parse("5a6f7cfd-23f0-4771-872f-da865ef865cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Edification",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14a4e219-25be-4e6b-986f-be9ba12ab318"), Type = TextBlockType.Text, Text = $"You've learned those tidbits of magic that are most conducive to furthering your acquisition and transmission of knowledge. You gain {ToMarkdownLink<Models.Entities.Spell>("guidance", Spells.Instances.Guidance.ID)}, {ToMarkdownLink<Models.Entities.Spell>("message", Spells.Instances.Message.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("sigil", Spells.Instances.Sigil.ID)} as innate occult cantrips." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("47a85644-0c6e-42e5-bbff-8e10a1e31816"), Feats.Instances.LoremasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("14e196db-aece-4e9d-8efb-9b17c57414dc"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0745575c-9a8d-4852-9d24-bbab1f785d22"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
