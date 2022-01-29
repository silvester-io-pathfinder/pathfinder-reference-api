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
    public class ArcaneTattoos : Template
    {
        public static readonly Guid ID = Guid.Parse("fb0b0597-7452-447b-ab93-85e114a57a1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Tattoos",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c596b55-5a1b-4644-a09d-2b4a60549b86"), Type = TextBlockType.Text, Text = $"~ Access: Varisian ethnicity or New Thassilon nationality" };
            yield return new TextBlock { Id = Guid.Parse("226bce74-f310-4f7b-8ab2-863119784e7a"), Type = TextBlockType.Text, Text = $"You have tattoos on your body corresponding to one of the ancient Thassilonian schools of magic. Choose one of the following schools of magic: abjuration ({ToMarkdownLink<Models.Entities.Spell>("shield", Spells.Instances.Shield.ID)}), conjuration ({ToMarkdownLink<Models.Entities.Spell>("tanglefoot", Spells.Instances.Tanglefoot.ID)}), enchantment ({ToMarkdownLink<Models.Entities.Spell>("daze", Spells.Instances.Daze.ID)}), evocation ({ToMarkdownLink<Models.Entities.Spell>("electric arc", Spells.Instances.ElectricArc.ID)}), illusion ({ToMarkdownLink<Models.Entities.Spell>("ghost sound", Spells.Instances.GhostSound.ID)}), necromancy ({ToMarkdownLink<Models.Entities.Spell>("chill touch", Spells.Instances.ChillTouch.ID)}), or transmutation ({ToMarkdownLink<Models.Entities.Spell>("sigil", Spells.Instances.Sigil.ID)}). You can cast the associated cantrip (listed in parentheses) as an innate arcane spell at will." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d568090-b6d2-4190-a82a-aa45018129b1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
