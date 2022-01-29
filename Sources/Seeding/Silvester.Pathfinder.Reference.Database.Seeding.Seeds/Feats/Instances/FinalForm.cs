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
    public class FinalForm : Template
    {
        public static readonly Guid ID = Guid.Parse("d6b8e62f-47be-44c5-b016-582ab3683f1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Final Form",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "At the GM's discretion, the specific elements of this feat can be adjusted to better fit the tiefling's lineage—for example, a GM might decide that a particular beastbrood tiefling could cast a 6th-level (spell: phantasmal killer) instead of (spell: fireball).",
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6856abf5-340a-4eee-bdcb-012bfaeac624"), Type = TextBlockType.Text, Text = $"You embrace your monstrous blood and make it your own, screaming out to the heavens and hells alike in rage, pain, and defiance. Reality buckles and twists under your sudden power—each tiefling has a unique transformation, but it might include sulfurous flames, choruses of shrieks, or twisting, serpentine lightning. Every creature within 10 feet of you is deafened and dazzled for 1 round unless they succeed at a Fortitude save using your class DC or spell DC, whichever is higher. Your final form has the effects of {ToMarkdownLink<Models.Entities.Spell>("divine vessel", Spells.Instances.DivineVessel.ID)} for a deity that shares an alignment with your fiendish lineage. Your final form resembles a creature from your fiendish lineage, and you remain in that form for 1 minute. While in your final form, you can cast {ToMarkdownLink<Models.Entities.Spell>("chilling darkness", Spells.Instances.ChillingDarkness.ID)}, {ToMarkdownLink<Models.Entities.Spell>("fireball", Spells.Instances.Fireball.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("lightning bolt", Spells.Instances.LightningBolt.ID)} as 6th-level divine innate spells, once each per use of this feat." };
            yield return new TextBlock { Id = Guid.Parse("2076956a-7bf9-459b-914c-e8f92c8f867e"), Type = TextBlockType.Text, Text = $"When you emerge from your final form, you become drained 3. In addition, if you have this feat, you gain weakness 10 to good even when not in your final form, and you take good damage even if you aren't evil." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cca55a0-6392-4024-afda-a4fa8d435533"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
