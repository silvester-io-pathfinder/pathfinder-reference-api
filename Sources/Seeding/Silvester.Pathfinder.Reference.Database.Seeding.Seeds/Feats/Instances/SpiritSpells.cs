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
    public class SpiritSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("e4e5262b-e346-4288-90fa-b26ee355b5bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirit Spells",
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
            yield return new TextBlock { Id = Guid.Parse("f81ecc25-57bf-4748-902b-8a69b7c34cf6"), Type = TextBlockType.Text, Text = $"Your ability to confront incorporeal menaces develops into full-fledged spellcasting. Choose a 1st-level occult spell. You can {ToMarkdownLink<Models.Entities.Rule>("Cast this Spell", Rules.Instances.CastASpell.ID)} as an innate occult spell. At 6th level, you gain a 2nd-level occult spell, and at 8th level, you gain a 3rd-level occult spell. Each of these spells must have the {ToMarkdownLink<Models.Entities.Trait>("divination", Traits.Instances.Divination.ID)}, {ToMarkdownLink<Models.Entities.Trait>("enchantment", Traits.Instances.Enchantment.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("necromancy", Traits.Instances.Necromancy.ID)} trait. You can cast each of these spells once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2ddf1189-6909-405c-8674-33a1dc587790"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49614ce8-819d-42c3-9074-086c51c1d655"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
