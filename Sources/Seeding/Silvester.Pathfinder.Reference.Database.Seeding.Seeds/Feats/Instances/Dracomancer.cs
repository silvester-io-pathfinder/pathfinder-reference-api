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
    public class Dracomancer : Template
    {
        public static readonly Guid ID = Guid.Parse("5191533e-7629-446b-9a83-2ad13f3d635e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dracomancer",
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
            yield return new TextBlock { Id = Guid.Parse("4bd3eda3-13e7-4e1c-bde4-980bad769608"), Type = TextBlockType.Text, Text = $"Your inborn arcane power manifests as your exemplar's most time-honored spells. Choose one 1st-level spell and one 2nd-level spell from those listed for a dragon spellcaster of your draconic exemplar's type (such as {ToMarkdownLink<Models.Entities.Spell>("alarm", Spells.Instances.Alarm.ID)}, {ToMarkdownLink<Models.Entities.Spell>("blur", Spells.Instances.Blur.ID)}, {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("true strike", Spells.Instances.TrueStrike.ID)} for a black dragon exemplar). You can cast each of these spells once per day as arcane innate spells. You gain the trained proficiency rank in arcane spell attack rolls and spell DCs, and your key spellcasting ability is Charisma." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7072878-e18d-41fb-a12f-594dc4c3cce0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
